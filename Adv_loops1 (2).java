Find how many times will the print statement be printed. will get printed out;
---------------------------------------------------
1.)
x=0; //set x to be 0
while(x<4){
	y=0; //set y to be 0
	while(y<5){
		print ("hello world");
		y = y+1;  //increase y by 1
	}
	x=x+1; //increase x by 1
}//=20
---------------------------------------------------
2.)
x=0; //set x to be 0
y=0; //set y to be 0
while(x<4){
	while(y<5){
		print ("hello world");
		y = y+1;  //increase y by 1
	}
	x=x+1; //increase x by 1
}//=5
---------------------------------------------------
3.)
x=0; //set x to be 0

while(x<4){
	y=0; //set y to be 0
	while(y<6){
		print ("hello world");
		if(x<3){
			y=y+1; //increase y by 1
		y = y+1;  //increase y by 1
	}
	x=x+1; //increase x by 1
}//x4  y6  333111111=15
---------------------------------------------------
4.)
while(Hour==0 or 24){
	Hour=0; //set x to be 0
	while(Hour<24){
		Minute=0;//set y to be 0
		while(Minute<60){
			second=0;//set z to be 0
			while(second<60){
				sleep(1000)//wait 1 second
				print(Hour:Minute:second);  //how many times does this get printed.?
				second=second+1;//increase z by 1
			}
			Minute=Minute+1;
		}	
		Hour=Hour+1;
	}//=86,400
}//program keeps track of time.