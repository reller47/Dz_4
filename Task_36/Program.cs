double[] array = new double[4];
double sum = 0;
for(int i =0; i < array.GetLength(0); i++){
    array[i] = new Random().Next();
    Console.Write(array[i] + "  ");
}
for(int i =0; i < array.GetLength(0); i++){
    if((i % 2) != 0){
        sum = sum + array[i];
    }
}
Console.WriteLine("Result = " + sum);