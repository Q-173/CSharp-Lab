class CourseRegistration
{ 
   private string studentName;
   private int creditHours;
   
   public string StudentName
   {
       get {return studentName;}
       set {
           if(string.IsNullOrWhiteSpace(value))
           { throw new ArgumentException("Student name cannot be empty.");}
          
           studentName=value.Trim();
       }
   }
   
   public int CreditHours
   {
       get{return creditHours;}
       set {
           if(value<1 || value>21)
           {throw new ArgumentOutOfRangeException("Credit hours must be between 1 to 21");}
           creditHours=value;
       }
   }
   //Constructors
   public CourseRegistration():this("unknown",1){}
   public CourseRegistration(string name):this(name,1){}
   
   public CourseRegistration(string name,int hour)
   {
      StudentName=name;
      CreditHours=hour;
   }
   
   public void PrintCourseRegistration()
   {
       try {
           Console.Write("Enter student name:");
           string name=Console.ReadLine();
           
           Console.Write("Enter cerdit hours:");
           string input=Console.ReadLine();
           if(!int.TryParse(input,out int hours))
           {throw new FormatException("Credit hours must be number.");}
           
           CourseRegistration course=new CourseRegistration(name,hours);
           
           Console.WriteLine($"Student name:{course.StudentName}");
           Console.WriteLine($"Credit hours:{course.CreditHours}");
           Console.WriteLine("Rsgistration successful.");
       }
       catch(FormatException ex)
       {
           Console.WriteLine($"Error:{ex.Message}");
       }
       catch(Exception ex)
       {
           Console.WriteLine($"Error:{ex.Message}");
       }
   }
   
}