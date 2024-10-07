using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDataTypes
{
    internal class Class03
    {
        /*
        [ 프로퍼티 ]
        - 클래스의 필드에 간접적으로 접근할수 있게 해주는 것.
        - 데이터 캡슐화와 접근 제어를 가능하게 함.
        */
        class Circle
        {
            double pi = 3.14;
            // 구방식(메서드를 통해 필드로 접근)
            double GetArea(double radius)
            {
                return radius * radius * pi;
            }
            // 명시적인 프로퍼티
            // get, set
            public double Pi
            {
                get { return pi; }
                set { pi = value; }
            }
        }
        class Person
        {
            // 자동구현 프로퍼티
            public string name { get; set; }
            // 아래와 같은 형태로 만들어줌
            //private string _name;
            //public string Name
            //{
            //    get { return _name; }
            //    set { _name = value; }
            //}
        }
        class Person1
        {
            // 읽기 전용 프로퍼티
            // 아래와 같은 형태는 초기화된 후 변경할 수 없다.
            // 따라서 생성자를 통해 값을 설정해야 함.
            public string name { get; }
            public Person1(string name)
            {
                this.name = name;
            }
        }
        class Person2
        {
            // 외부에서 값을 설정할수 있지만 읽을 수 없다.
            private string _name;
            public string Name { set { _name = value; } }   // 쓰기 전용
        }
        static void Main(string[] args)
        {
            Person person = new Person();

            person.name = "test";
            Console.WriteLine(person.name);

            //Person1 person1 = new Person1();
            //person1.name = "ddd";

            Person2 person2 = new Person2();
            person2.Name = "345";

            //Console.WriteLine(person2.Name);
        }
    }
}