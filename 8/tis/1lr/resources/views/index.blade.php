<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Main page</title>
    <link rel="stylesheet" href="{{ asset('main.css') }}">
</head>
<body>
    <div class="main-cont">
        <div class="actions">
            <form class="edit-cont" action="{{ route('index.store') }}" method="POST">
                @csrf
                <h2>Создание</h2>
                <label for="name">Имя</label>
                <input type="text" name="name">
                <label for="phone">Номер телефона</label>
                <input type="text" name="phone">
                <button type="submit">Создать</button>
            </form>
        </div>
        <div class="list-cont">
            <h2>Список</h2>
            <form action="{{ route('index.search') }}" method="GET">
                <input type="text" name="q" placeholder="Найти..." autocomplete="off">
                <button type="submit">Найти</button>
            </form>
            <div class="list">
                <ul>
                    @foreach ($items as $item)
                        <li>{{ $item->name }} : {{ $item->phone }}
                        <form action="{{ route('index.destroy', $item)}}" method="POST">
                            @csrf
                            <button type="submit">Удалить</button>
                        </form>
                        </li>
                        <hr>
                    @endforeach
                </ul>
            </div>
        </div>
    </div>
</body>
</html>