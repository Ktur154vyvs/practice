﻿using UnityEngine;
using System.Collections;

public class times : MonoBehaviour {
	public int timersecond; // проверка отчёта секунд в Inspector
	private float secondgametime; //(?) - нужно для работы Time.deltaTime
	public float minedgametime;// проверка отчёта минут в Inspector
	void Update () { // обновляет код каждый кадр

		secondgametime += Time.deltaTime;
		// расчитывакт интерфал времени.К примеру если хотите что бы счёстчик считал быстрее 
		//измените secondgametime >=1 на secondgametime => 0.5 , медленее - наоборот
		if (secondgametime >= 1) {
			// если secondgametime больше или равен нулю, тогда прибаляет одну секунду в наш счётчик
			timersecond += 1;
			//приравнивает счётчик Unity к нашему сеундному счётчику, тоесть счётчик Unity начинает 
			//отчёт от 0.0000, и когда доходит до еденицы сбрасывается до нуля
			secondgametime = 0; // (?) - у нас в secondgametime записан счётчик Unity
		}
		//проделываем то же самое только уже с минутами
		if (timersecond >= 60) {
			//Если timersecond равен или больше 60, тогда к minegametime прибавляем одну минуту
			minedgametime += 1;
			//Сбрасываем секунды (возращяем секунды в исходное положение)
			timersecond = 0;
		}
		//проделываем работу над сбросом минут
		if (minedgametime >= 60){
			// Если minegametime больше или равен 60, тогда minegametime будет равен нулю
			minedgametime = 0; //(?) - если мы запишем minegametime = 0 под if(timersecond >=60){
			//тогда счётчик будет думать, что если секунды больше или равны 60 ,то минуты 
			//будут равны нулю, тоесть минуты будут постоянно 0
		}
	}
	//вывод на экран
	void OnGUI (){
		//Screen.width не даёт расползаться GUI (Графический элемент) по всему экрану, на разных по размеру экранам
		GUI.Label(new Rect(Screen.width - 500,10,100,50), "SecondTime : " + timersecond);
		GUI.Label(new Rect(Screen.width - 500, 25, 100, 50), "MinutesTime : " + minedgametime);
	}
}