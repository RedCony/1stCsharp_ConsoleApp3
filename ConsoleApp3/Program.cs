using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;                    // IFormatter 인터페이스 사용을 위해 추가
using System.Runtime.Serialization.Formatters.Binary;  // 바이너리 포맷을 위해 추가 
using System.IO;						               //Stream 객체를 사용하기 위해서 


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherMgr mgr = new TeacherMgr(6);
            mgr.CreateTeachers(eTeacherType.eTeacher_Math, "suyung", 45, 550);

            mgr.Teaching();
        }
    }
}




















































/*
TeaCher_DicMgr mgr = new TeaCher_DicMgr(2);

mgr.CreateTeachers(eTeacherType.eTeacher_kor, "kim", 600, 28);
mgr.CreateTeachers(eTeacherType.eTeacher_Math, "Lee", 500, 30);
mgr.CreateTeachers(eTeacherType.eTeacher_Math, "suyung", 550, 45);
mgr.CreateTeachers(eTeacherType.eTeacher_Music, "min", 450, 36);
mgr.CreateTeachers(eTeacherType.eTeacher_kor, "dong", 500, 48);
mgr.CreateTeachers(eTeacherType.eTeacher_Music, "Lee1", 500, 48);



mgr.SortbyeType(0);





/*          mgr.DisPlayInfo();

          mgr.ReMove("kim");

         mgr.DisPlayInfo();
*/

/*
TeaCher_ListMgr mgr = new TeaCher_ListMgr(2);

mgr.CreateTeachers(eTeacherType.eTeacher_kor, "kim", 600, 28);
mgr.CreateTeachers(eTeacherType.eTeacher_Math, "Lee", 500, 30);
mgr.CreateTeachers(eTeacherType.eTeacher_Math, "suyung", 550, 45);
mgr.CreateTeachers(eTeacherType.eTeacher_Music, "min", 450, 36);
mgr.CreateTeachers(eTeacherType.eTeacher_kor, "dong", 500, 48);
mgr.CreateTeachers(eTeacherType.eTeacher_Music, "Lee", 500, 48);

Console.WriteLine("----------이름 순 오름 차순 정렬하기-------------");

mgr.ShortType(0);

/*
Console.Write("삭제 ");
mgr.ReMove("Lee");


/*
mgr.Teaching();
Console.WriteLine("--------------------------");
mgr.DisPlayInfo();
Console.WriteLine("--------------------------");

Console.WriteLine("검색 합니다.");
TeaCher findTeaCher = mgr.FindTeacher("Lee");

if (findTeaCher != null)
{
    findTeaCher.DisPlayInfo();
}
*/

/*
TeaCher[] findTeaChers = mgr.FindTeachers("Lee");

if (findTeaChers != null)
{
  foreach(TeaCher teaCher in findTeaChers)
    {
        teaCher.DisPlayInfo();
    }
}

/*
List<string> list = new List<string>();

// 동적 추가 
list.Add("1번째");
list.Add("2번째");
list.Add("3번째");
list.Add("4번째"); // 1번째 2번째 3번째 4번째 



Console.WriteLine(list[1]); // 출력 : 2번째 
Console.WriteLine(list.Capacity); // 출력 : 4 
Console.WriteLine(list.Count); // 출력 : 4 
Console.WriteLine("------------------------------------------");

Console.WriteLine("-----------------삭제-------------------------");

list.RemoveAt(2); // 1번째 2번째 4번째 
foreach (string str in list)
{
    Console.WriteLine(str);
}
Console.WriteLine("------------------------------------------");

Console.WriteLine("-----------------삭제 아이템-------------------------");

list.Remove("4번째"); // 1번째 3번째 

foreach (string str in list)
{
    Console.WriteLine(str);
}
Console.WriteLine("------------------------------------------");

Console.WriteLine("----------------새 아이템--------------------------");

list.Insert(5, "새 0번째"); // "새 0번째 1번째 3번째
foreach (string str in list)
{
    Console.WriteLine(str);
}
*/

/*
TeacherMgr mgr = new TeacherMgr(6);

mgr.CreateTeachers(eTeacherType.eTeacher_kor, "kim", 28, 600);
mgr.CreateTeachers(eTeacherType.eTeacher_Math, "Lee", 30, 500);
mgr.CreateTeachers(eTeacherType.eTeacher_Math, "suyung", 45, 550);
mgr.CreateTeachers(eTeacherType.eTeacher_Music, "min", 36, 450);
mgr.CreateTeachers(eTeacherType.eTeacher_kor, "dong", 48, 500);
mgr.CreateTeachers(eTeacherType.eTeacher_Music, "Lee", 48, 500);
*/

//mgr.DisPlayInfo();

// TeaCher findTeaCher = mgr.FindTeacher("Lee");

//findTeaCher.DisPlayInfo();

//TeaCher[] findTeaChers = mgr.FindTeachers("Lee");

/*
for (int nn=0;nn< findTeaChers.Length; nn++)
{
    if (findTeaChers == null)
        return;

    for ( nn = 0; nn < findTeaChers.Length; nn++)
    {
        if (findTeaChers[nn] == null)
            continue;

        findTeaChers[nn].DisPlayInfo();
    }
}
*/
/*
foreach (TeaCher teacher_ in mgr.FindTeachers("Lee"))
{
        teacher_.DisPlayInfo();
}
*/


/*
Console.WriteLine("삭제할 선생님은:");

mgr.Delete("kim");

Console.WriteLine("현재 정보 모두 출력");

mgr.DisPlayInfo();
*/



