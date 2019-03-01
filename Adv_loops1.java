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
}
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
}
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
}
---------------------------------------------------
4.)
x=0; //set x to be 0
while(x<24){
	y=0;//set y to be 0
	while(y<60){
		z=0;//set z to be 0
		while(z<60){
			sleep(1000)//wait 1 second
			print(x:y:Z);  //how many times does this get printed.?
			z=z+1;//increase z by 1
		}
		y=y+1;
	}
	x=x+1;
}