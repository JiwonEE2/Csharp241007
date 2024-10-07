using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241007
{
    internal class Program01
    {
        static void Main(string[] args)
        {
            /*
            조건문, 반복문 C++과 동일

            배열은 조금 다름.
            배열 : 동일한 자료형의 요소들로 구성된 데이터의 집합
            인덱스를 통해 배열의 요소에 접근 가능
            배열의 처음 요소의 인덱스는 0부터 시작

            [ 배열 기본 ]
            - 배열을 만들기 위해 자료형과 크기를 정하여 생성
            - 배열의 요소에 접근하기 위해[인덱스]를 사용
            - 배열의 Length를 통해 크기를 확인
            - 자료형[] 배열이름 = new 자료형[크기];
            */
            int[] scores = new int[5];
            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;

            Console.WriteLine($"배열의 0번째 요소 : {scores[0]}");
            Console.WriteLine($"배열의 1번째 요소 : {scores[1]}");
            Console.WriteLine($"배열의 2번째 요소 : {scores[2]}");
            Console.WriteLine($"배열의 3번째 요소 : {scores[3]}");
            Console.WriteLine($"배열의 4번째 요소 : {scores[4]}");

            /*
            int[] arr1;     // 배열 변수 선언
            arr1 = new int[3];
            int[] arr2 = new int[3] { 1, 2, 3 };    // 크기가 3인 배열 선언하고 초기화
            int[] arr3 = new int[] { 1, 2, 3 };     // 배열의 요소들을 초기화하는 경우 배열의 크기를 생략 가능
            int[] arr4 = { 1, 2, 3 };               // 배열의 요소를 초기화하는 경우 배열 생성 생략 가능

            [ 배열의 구현 원리 ]
            - C#의 배열은 Array클래스를 통해 구현
            - 따라서 Array클래스의 모든 특징을 가짐
            - Array클래스의 정적 함수를 활용하여 다양한 기능 사용 가능
            */

            int[] array = { 1, 3, 5, 4, 2 };
            int length = array.Length;  // 배열의 크기
            int max = array.Max();      // 배열의 최대값
            int min = array.Min();      // 배열의 최소값

            Array.Sort(array);                      // 정렬
            Array.Reverse(array);                   // 반전
            int index = Array.IndexOf(array, 3);    // 탐색

            int[] shallow = array;                  // 얕은 복사 : 동일한 인스턴스 참조
            int[] deep = new int[array.Length];     // 깊은 복사 : 새로운 인스턴스 생성하고 복사
            Array.Copy(array, deep, array.Length);

            // 배열의 형식과 길이를 명시
            // 3개의 원소를 가진 배열이 2개
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            // 배열의 길이를 생략
            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            // 형식과 길이를 모두 생략
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i},{j}] : {arr[i, j]}");
                }
                Console.WriteLine();
            }

            /*
            [ 가변 배열 ]
            - 배열의 []괄호를 배열 갯수만큼 추가
            - 배열의 크기를 각각 설정 가능
            */
            int[][] jagged = new int[3][];
            jagged[0] = new int[5];
            jagged[1] = new int[2];
            jagged[2] = new int[3];

            /*
            [0][0]  [0][1]  [0][2]  [0][3]  [0][4]
            [1][0]  [1][1]
            [2][0]  [2][1]  [2][2]
            */

            /*
            아파트 주민 수 구하기
            1. 각 층에는 3개의 호실만 있고 3층까지 있음
            2. 각 층에 각 호의 가족이 몇 명 산다는 입력을 받고 배열에 저장
            3. 아파트에는 총 몇 명이 살고 있을까요?
            */

            int[,] apart = new int[3, 3];
            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("각 층 호수에 가족은 몇 명이 살고 있나? {0}층 {1}호\t", i + 1, j + 1);
                    apart[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    total += apart[i, j];
                }
            }
            foreach (var item in apart)
            {
                total += item;
            }
        }
    }
}