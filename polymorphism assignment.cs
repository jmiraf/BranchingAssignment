//1. Create an interface called IQuittable and have it define a void method Quit()
namespace PolymorphismAssignment
{
	interface IQuittable
	{
		void Quit();
	}

}

//2. Have your Employee Class from previous drill inherit that interface and implement Quit() method
namespace PolymorphismAssignment
{
		public class Employee: IQuittable
		{
			public string firstName {get; set;}
			public string lastName {get; set;}
			public int Id {get; set;}
			//Implement the SayName() method inside the Employee class
			public override void SayName()
			{
				Console.WriteLine("Name: " + firstName + " " + lastName);
			}
			public void Quit()
			{
				throw new NotImplementedException();
			}
		}

}

//3. Create an object of type IQUittable and call the Quit() method on it
namespace PolymorphismAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
			IQuittable name = new Employee();
			name.Quit();
			Console.ReadLine();
		}
	}
}


