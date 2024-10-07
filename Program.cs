namespace Csharp241007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 기본 출력
            Console.WriteLine("Hello, World!");

            // 2. 변수
            //int a = 1;
            //Console.WriteLine(a);

            // 3. Format메서드
            // 중괄호를 이용하여 코드에서 사용하는 변수나 서식을 넣어주는 방법
            // 중괄호 내부에 넣는 숫자를 첨자. 첨자의 시작은 0부터
            // 문자열이 끝나고 콤마 뒤에 순서대로 0,1,2에 맞게 넣을 변수를 입력
            Console.WriteLine("경일 : {0},{1}", "이힛", 1234);

            int num = 1;

            string str3 = string.Format("경일 : {0},{1},{2}", "호호", 1234, num);
            Console.WriteLine(str3);

            // 3. 문자열 보간을 이용한 방법
            // format 방식과 달리 string 안에 직접 변수 이름을 넣는다.
            int a = 10;
            int b = 10;

            Console.WriteLine($"테스트 : {a}+{b}={a + b}");

            /*
            [ Data Types ]
            - 논리형
            bool

            - 정수형
            byte
            sbyte

            short
            int
            long

            ushort
            uint
            ulong

            - 실수형
            float
            double

            - 문자형
            char
            string
            */

            // 상수
            const int Max = 200;
            //const int min;  // 초기화 없이 사용 불가능
            //Max = 111;      // 데이터 변경 불가

            /*
            [ 형변환 ]
            < 명시적 형변환 >
            - 변환할 데이터의 앞에 변환할 자료형을 괄호 안에 넣어 형변환 진행
            //int intvalue = 1.2;     // 명시적 형변환없이 변환 불가
            int intvalue = (int)1.2;
            Console.Write(intvalue);

            < 묵시적 형변환 >
            - 변수에 데이터를 넣는 과정에서 자료형이 더 큰 범위를 표현하는 경우 자동으로 형변환 진행
            float floatvalue = 3;       // 부동소수점현 변수에 정수형 데이터를 넣을 경우 자동 형변환 가능
            double doublevalue = 1.2f;  // double은 float을 포함하는 큰 범위이기 때문에 자동 형변환 가능

            < 문자열 형변환 >
            - 문자열은 단순 형변환 불가
            - 각 자료형의 Parse, TryParse를 이용하여 문자열에서 자료형으로 변환
            int value = int.Parse("1234");
            - ToString : 문자열로 형변환
            string text1 = (true).ToString();
            string text2 = (1234).ToString();
            */

            // 기본적으로 우리가 알고 있는 int, float은 값형식
            // 아래와 같은 object타입은 참조형식이기 때문에 힙에 할당됨
            // 아래와 같은 값형식의 데이터를 오브젝트 형식 객체에 담았을 경우
            // 오브젝트 형식은 값형식의 데이터를 힙에 할당하기 위해 박싱이라는 기능을 제공
            // 오브젝트 형식에 값형식의 데이터를 할당하려고 한다면 오브젝트 형식은 박싱을 사용해서
            // 해당 데이터를 힙에 할당

            // 1. object a = 3;
            // 2. int b = (int)a;

            // 1.에서의 a는 3이 박싱되어 저장된 힙을 참조하고 있고
            // 2.에서의 b는 a가 참조하고 있는 메모리부터 값을 복사하려고 함.

            int a1 = 11234;
            //object b = a1;  // a에 담긴 값을 박싱해서 힙에 저장
            int c = (int)b; // b에 담긴 값을 언박싱해서 스택에 저장

            // 값형식
            int n1 = 5;
            int n2 = n1;

            // 참조형식
            string s1 = "dd";
            string s2 = s1;
        }
    }
}