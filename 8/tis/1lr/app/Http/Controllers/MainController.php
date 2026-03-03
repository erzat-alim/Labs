<?php

namespace App\Http\Controllers;

use App\Models\BookItem;
use Illuminate\Http\Request;

class MainController extends Controller
{
    public function index(){
        $items = BookItem::all();
        return view('index', compact('items'));
    }
    public function store(Request $request){
        $request->validate([
            'name'=>'required',
            'phone'=>'required|min:11'
        ]);
        BookItem::create([
            'name'=>$request->name,
            'phone'=>$request->phone
        ]);
        return redirect()->route('index');
    }
    public function destroy(BookItem $item){
        $item->delete();
        return redirect()->route('index');
    }
    public function search(Request $request){
        $query = $request->query('q');
        $items = BookItem::where('name', 'like', "%$query%")
        ->orWhere('phone', 'like', "%$query%")
        ->get();
        return view('index', compact('items'));
    }
}
