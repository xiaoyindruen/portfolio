"use strict"

/*
   New Perspectives on HTML5 and CSS3, 8th Edition
   Tutorial 9
   Coding Challenge 1

   Clock
   Author: Xiaoyin Druen
   Date:   11/24/2020

   function getWeekday(dayNum)
      Returns the text of the day of the week where dayNum
      is the number of the week from 0 (Sunday) to 6 (Saturday)
*/
runClock();
setInterval("runClock()", 1000);

function getWeekday(dayNum) {
   var wDays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
   return wDays[dayNum];

   var thisDay = new Date();
   var thisDate = thisDate.toLocaleDateString();
   var thisDayNum = thisDate.getDay();
   var thisWeekday = thisDayNum.getWeekday();
   var thisTime = thisDate.toLocaleTimeString(); 

   document.getElementById("date").textContent = thisDate;
   document.getElementById("wday").textContent = thisWeekday;
   document.getElementById("time").textContent = thisTime;

}
