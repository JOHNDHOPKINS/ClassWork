
static void ALoopFunction(int numTimes){
	if(numTimes <=0){
		return;
	}
	System.out.println("Hello World");
	numTimes = numTimes -1;
	ALoopFunction(numTimes);
	return;
}


static int SomeMathFunction(int num1){
	if(num1 <=1){
		return 1;
	}
	num1 = num1* SomeMathFunction(num1-1);
	return num1;
}