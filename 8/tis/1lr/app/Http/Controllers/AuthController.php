<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Validator;
use Illuminate\Support\Facades\Auth;

class AuthController extends Controller
{
    public function showLogin(){
        return view('login');
    }
    public function login(Request $request){
        $validator = Validator::make($request->all(),[
            'email'=>'required|email',
            'password'=>'required|min:3'
        ]);
        if ($validator->fails()){
            return back()
                ->withErrors($validator)
                ->withInput();
        }
        if (!Auth::attempt($request->only('email', 'password'))){
            return back()
                ->withErrors(['email'=>'Invalid credentials'])
                ->withInput();
        }
        return redirect()->route('index');
    }
    
}
