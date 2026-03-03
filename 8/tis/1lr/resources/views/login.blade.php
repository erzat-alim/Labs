<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="{{ asset('main.css') }}">
</head>
<body>
    <form action="/login" method="POST" class="login">
        @csrf
        <h2>Авторизация</h2>
        <input type="email" placeholder="Email" name="email">
        <input type="password" placeholder="Пароль" name="password">
        @if ($errors->any())
            <div style="color: red">{{ $errors->first() }}</div>
        @endif
        <button type="submit">Войти</button>
    </form>
    
</body>
</html>