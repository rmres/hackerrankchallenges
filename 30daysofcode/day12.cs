using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int id, int[] scores){
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        testScores = scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate() {
        int total = 0;
        int average = 0;
        for (int i = 0; i < testScores.Length; i++) {
            total+=testScores[i];
            average = total/testScores.Length;
        }
        char grade = '\0';
        
        if (average >= 90 && average <= 100) {
            grade = 'O';
        }
        else if (average >= 80 && average < 90) {
            grade = 'E';
        }
        else if (average >= 70 && average < 80) {
            grade = 'A';
        }
        else if (average >= 55 && average < 70) {
            grade = 'P';
        }
        else if (average >= 40 && average < 55) {
            grade = 'D';
        }
        else {
            grade = 'T';
        }
        return grade;
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}