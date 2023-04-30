# HTTProject

## Задача

Нужно создать веб-приложение, выдающее результаты запроса к базе данных, например, выдающее в форме результат в виде joined таблицы товаров и соответствующих им категорий. В БД должны быть 2 таблицы: товары и категории. Можно использовать Entity Framework.
Результат нужно опубликовать в гитхаб и сделать небольшую видео-презентацию проекта.

## Пререквизиты

Создайте миграцию командой - `dotnet ef --project HTTApp migrations add InitialCreate`

Обновите базу данных командой - `dotnet ef --project HTTApp database update`

## Как использовать проект

Запустите проект и на главной странице будет выведена joind-таблица с товарам и категориями. 

## Презентация

> https://disk.yandex.ru/i/bpMioauTPi_cHQ