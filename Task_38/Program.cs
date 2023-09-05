double[] array = {3.22, 1.2, 24.6, 0.8 , 9.245};
double max = array[0];
double min = array[0];
for(int i = 0; i < array.GetLength(0); i++){
    if(array[i] > max){
        max = array[i];
    }
    else{
        if(array[i] < min){
        min = array[i];
        }
    }
}
Console.WriteLine("Result = " + (max - min));