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
 * ЦВЕТ ЗАКРАСКИ, ЦВЕТ КОНТУРА И ОПИСЫВАЮТ МЕТОД 
 * ПОЛУЧЕНИЯ МАССИВА ТОЧЕК ИХ АППРОКСИМИРУЮЩИЙ
 * (ТОЧКИ БУДУТ ТАКИЕ БУДТО ЛЕВЫЙ ВЕРХНИЙ УГОЛ ЭТО 0;0)
 * 
 * В КОНТРОЛЛЕРЕ БУДЕТ ХРАНИТСЯ СПИСОК ФИГУР 
 * НУ И ДОБАВЛЯТЬСЯ УДАЛЯТЬСЯ БЛЯТЬ ОЧЕВИДНО
 * И ДАЛЕЕ В СООТВЕТСВИИ С МЕТОДОМ ТОЧЕК ЭТИХ
 * ОНО БУДЕТ НАНОСИТЬСЯ НА ФОРМУ
 *
 * ЭТО ГОВНО ВСЕ БУДЕТ СЕРИАЛИЗУЕМОЕ И ДЕСЕРИАЛИЗУЕМОЕ
 * ЧТОБЫ СОХРАНЯТЬ И ГРУЗИТЬСЯ ИЗ ФАЙЛОВ
 * 
 * ТАКЖЕ БУДЕТ КОМПЛЕКСНАЯ ФИГУРА - ОНА ХРАНИТ В СЕБЕ НЕСКОЛЬКО ДРУГИХ
 * 
 */
public abstract class Drawer(Shape figure)
{
    protected Shape Figure { get; set; } = figure;
    public abstract void Draw();
}
