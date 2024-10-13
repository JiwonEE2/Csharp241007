using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241007
{
	internal class Class02
	{
		// 생성자를 다시 봅시다.
		class Person
		{
			// 1. 생성자가 없어도
		}
		// 2. 매개변수가 있는 생성자
		class Person1
		{
			public int age;
			public string name;
			public Person1(int age, string name)
			{
				this.age = age;
				this.name = name;
			}
		}
		// 3. 생성자 오버로딩
		class Person2
		{
			public string name;
			public int age;

			//기본생성자
			public Person2()
			{
				name = "ggg";
				age = 1;
			}
			public Person2(string name)
			{
				this.name = name;
				age = 2;
			}
		}
		class Person3
		{
			public string name;
			public int age;
			public Person3() : this("홍길동", 3) { }
			//
			public Person3(string name, int age)
			{
				this.name = name;
				this.age = age;
			}
		}
		class Person4
		{
			public static int age;
			public Person4()
			{
				age = 4;
			}
		}
		static void Main(string[] args)
		{
			Person p1 = new Person();           // 1. 기본생성자 호출
			Person1 p2 = new Person1(1, "ddd"); // 2. 매개변수가 있는 생성자

			Person3 p3 = new Person3();
			Person4 p4 = new Person4();

			Console.WriteLine(Person4.age);
		}
	}
}