<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\AuthController;
use App\Http\Controllers\MainController;

Route::get('/', [AuthController::class, 'showLogin']);
Route::post('/login', [AuthController::class, 'login']);

Route::get('/index', [MainController::class, 'index'])->name('index');
Route::post('/index/add', [MainController::class, 'store'])->name('index.store');
Route::post('/index/delete/{item}', [MainController::class, 'destroy'])->name('index.destroy');
Route::get('/index/search', [MainController::class, 'search'])->name('index.search');