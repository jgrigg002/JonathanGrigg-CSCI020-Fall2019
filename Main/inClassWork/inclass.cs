using System;

class Compute {


/* Compute Sphere uses the equation to calc
ulate the volume of a sphere based on radius.

Input: Accepts a single integer for radius.

Output: double area of sphere */

static double ComputeSphere(int l){

double v = (4.0/3) * 3.14 * (l * l * l);

return v;

}

static double ComputeBox(int l, int w, int h){

double v = l * w * h;

return v;

}

static double ComputePyramid(int l, int h){

double v = (1.0/3) * l * h;

return v;

}

public static void Main (string[] args) {

int length = 1;

int width = 1;

int height = 1;

double sphereAnswer = 0.0;

double boxAnswer = 0.0;

double pyramidAnswer = 0.0;

length= int.Parse(Console.ReadLine());

width= int.Parse(Console.ReadLine());

height = int.Parse(Console.ReadLine());

sphereAnswer = ComputeSphere(length);

boxAnswer = ComputeBox(length, width, height);

Console.WriteLine ("Pyramid: " + ComputePyramid(length, height));

Console.WriteLine ("Sphere: " + sphereAnswer);

Console.WriteLine("Box: "+ boxAnswer);

}

}
