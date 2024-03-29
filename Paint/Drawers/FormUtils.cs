﻿using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

/* ТРЕБОВАНИЯ
 * 
 * УЛЬТРА СУПЕР ХАЙП ПЕЙНТ, ГДЕ МОЖНО РИСОВАТЬ КРУЖОЧКИ КВАДРАТИКИ ОВАЛЫ ТРЕУГОЛЬНИКИ
 * ЛИНИИ СТРЕЛОЧКИ И ХУИ
 * 
 * ПРИ ЭТОМ ИХ МОЖНО ЗАКРАШИВАТЬ В ЦВЕТА ХОХЛЯЦКОЙ ЖЕВТО ВОЛОХИТНОЙ ТРЯПКИ
 * 
 * И СОХРАНЯТЬ СВОЕ ГОВНО В КАКОЙ ТО ФАЙЛ И ОТТУДА ЗАГОТОВКИ ГРУЗИТЬ
 * 
 * ПЛАН ДЕЙСТВИЙ
 * 
 * ЕСТЬ СПИСОК МОДЕЛЕЙ, ДОХУЯ ПОЛИМОРФИЗМА, СУТЬ В ТОМ ЧТО ОНИ 
 * ХРАНЯТ В СЕБЕ КООРДИНАТЫ ЛЕВОГО ВЕРХНЕГО УГЛА ФИГУРЫ,
 * НУ И ПРАВОГО ВЕРХНЕГО, ЛЕВОГО НИЖНЕГО И ПРАВОГО НИЖНЕГО
 * ЦВЕТ ЗАКРАСКИ, ЦВЕТ КОНТУРА - ЭТО ШЕЙП ИНФО, А ТАКЖЕ МЕТОД
 * КОТОРЫЕ ВОЗВРАЩАЕТ DRAWER ДЛЯ ФИГУРЫ.
 * 
 * ФИГУРА - ПОНЯТИЕ АБСТРАКТНОЕ, КАЖДАЯ ВОЗВРАЩАЕТ АБСТРАКТНЫЙ DRAWER 
 * НО КОНКРЕТНАЯ ФИГУРА ВОЗВРАЩАЕТ КОНКРЕТНЫЙ DRAWER ДЛЯ ЭТОГО ТИПА ФИГУРЫ СУКА!
 * ТАК ПОСТРОЕНО ВСЕ БЛЯТЬ ЧТОБЫ ПРОСТО ХРАНИТЬ В КОНТРОЛЛЕРЕ ФИГУРЫ
 * И ДАЛЬШЕ НАПИСАТЬ SHAPE.GETDRAWER().DRAW();
 * ЧТОБЫ БЫЛО ОХУЕННО И  КРАСИВО БЛЯТЬ КАК МОЕ ЛИЦО С УРА ПОСЛЕ 
 * 3 ЧАСОВ СНА
 * 
 * ЧЕ НЕПОНЯТНО В АР_ХЕР_ТЕКТУРЕ - МНЕ В ЛС 
 * 
 * В КОНТРОЛЛЕРЕ БУДЕТ ХРАНИТСЯ СПИСОК ФИГУР 
 * НУ И ДОБАВЛЯТЬСЯ УДАЛЯТЬСЯ БЛЯТЬ ОЧЕВИДНО 
 * 
 * ЗАДАЧА - КОНТРОЛЛЕРА - ВЫПОЛНИТЬ КОНКРЕТНОЕ ДЕЙСТВИЕ -
 * ДОБАВИТЬ ФИГУРУ, ВЫЗВАТЬ ОТРИСОВКУ + СОХРАНИТЬ-ЗАГРУЗИТЬ В ФАЙЛ,
 * 
 * ЗАДАЧА ФОРМЫ - ОПРЕДЕЛИТЬ В ЗАВИСИМОСТИ ОТ КАКИХ ДЕЙСТВИЙ ЮЗЕРА
 * КАКИЕ НУЖНО МЕТОДЫ КОНТРОЛЛЕРА ВЫЗЫВАТЬ
 * КАК ОНА БУДЕТ ЭТО ДЕЛАТЬ МЕНЯ НЕ ЕБЕТ ГЛАВНОЕ ЧТОБЫ ПРАВИЬНО
 * 
 * ЭТО ГОВНО ВСЕ БУДЕТ СЕРИАЛИЗУЕМОЕ И ДЕСЕРИАЛИЗУЕМОЕ
 * ЧТОБЫ СОХРАНЯТЬ И ГРУЗИТЬСЯ ИЗ ФАЙЛОВ
 * НО НЕ МНЕ С ЭТИМ ТРАХАТЬСЯ :)
 * 
 * ТАКЖЕ БУДЕТ КОМПЛЕКСНАЯ ФИГУРА - ОНА ХРАНИТ В СЕБЕ НЕСКОЛЬКО ДРУГИХ
 * ПО СУТИ НИЧЕМ КРОМЕ ПОЛЯ ХРАНЯЩЕГО ФИГУРЫ ОНА НЕ ОТЛИЧАЕТСЯ
 */

public abstract class FormUtils(Shape figure)
{
    protected Shape Figure { get; set; } = figure;
    public abstract void Draw(Graphics graphics, Point p);

    public abstract bool InShape(Point p);
}
