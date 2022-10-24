# 소개

### C# 언어 둘러보기
* 개체(객체), 구성 요소 지향 프로그래밍 언어
* .NET에서 실행되는 다양한 형식의 애플리케이션 빌드 가능
* C, C++과는 다르게 [GC](https://learn.microsoft.com/ko-kr/dotnet/standard/garbage-collection/)를 포함
* `Nullable 형식`은 할당된 개체를 참조하지 않는 변수로부터 보호
* 예외 처리 - JAVA 처럼 Exception 처리 가능
* 람다식 - 함수형 프로그래밍 지원
* LINQ(언어 통합 쿼리)로 패턴화 가능
* [통합 형식 시스템](https://learn.microsoft.com/ko-kr/dotnet/csharp/fundamentals/types/) 지원
* JAVA와 유사하게 모든 객체는 Object class를 직/간접적으로 상속
* C와 C++의 메모리 직접 할당이 가능(포인터)
* 제네릭 지원
* 컬렉션 클래스 지원
* `virtual, override, overload`가능(상속, 추상화 등)


### .NET 아키텍처
* C# [프로그램은 CLR(Common Language Runtime)](https://learn.microsoft.com/ko-kr/dotnet/standard/clr)이라는 가상 실행 시스템
* .NET은 CLR 라이브러리 세트
* CLR은 국제 표준인 CLI(Common Language infra)를 MS에서 구현한 것(JVM이랑 유사하지만 좀 다른?)
* C#의 작동 구조
  1. CLI사양을 준수하는 [IL(Intermediate Language)](https://learn.microsoft.com/ko-kr/dotnet/standard/managed-code)컴파일
  2. 컴파일된 코드는 .dll와 함께 어셈블리에 저장
  3. 컴파일된 어셈블리가 CLR에 로드
  4. 로드된 어셈블리(IL)는 JIT(Just in time)컴파일을 수행
  5. 네이티브 기계어 명령으로 변환
  6. 실행
* CLR은 GC, Exception 처리, 리소스 관리 기타 서비스 등을 제공
* CLR에서 실행되는 코드를 `관리 코드`라고 함
* `관리 되지 않는 코드`는 특정 플랫폼을 대상으로 하는 네이티브 머신 언어로 컴파일 됨
* .NET의 주요 기능 - 언어 상호 운용성
  * C#에서 IL로 컴파일된 언어는 F#, VB, C++의 .NET버전에서 상호 작용이 가능
  * 이는 서로 참조가 가능함을 의미
* 런타임 서비스 외에도 .NET은 많은 라이브러리를 지원
  * 네임스페이스를 기준으로 구성
  * 문자열 조작
  * XML 구문 분석
  * Web Application
  * windows Forms
  * ...etc


### Hello World
```csharp
using System;
//조금 다르지만 유사해 보임
//using System; == import javax.utils.*;
```
* using은 자바의 import와 유사
* System namespace가 포함하고 있는 것
  * Console
  * IO
  * Collections
  * ...etc 

```csharp
Console.WriteLine == System.Console.WriteLine
```
* using 키워드를 통해 앞에 경로를 생략 할 수 있음

```csharp
class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, World");
    }
}
```
* `Main`은 static 한정자로 선언
* 인스턴스 메서드는 this를 활용 가능하지만, static 메서드는 특정 개체에 대한 참조 없이 작동
* 관례상 Main이 C# 프로그램의 진입점으로 사용
  * JAVA랑 동일한 관례를 가짐


### 형식 및 변수
* 형식은 C# 내부의 모든 데이터의 구조와 동작을 정의
* 형식 선언에는 해당 멤버, 기본 형식, 구현하는 인터페이스 및 해당 형식에 허용되는 작업이 포함될 수 있음
* 변수는 특정 형식의 인스턴스를 참조하는 레이블
* C#에는 `값 형식`과 `참조 형식` 2가지가 있음
 
  * [값 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/value-types)
    * 해당 데이터가 직접 포함(JAVA 프리미티브 타입과 유사)
    * [단순 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/value-types#built-in-value-types)
      1. [부호 있는 정수](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) - `short`, `int`, `long`
      2. 부호 없는 정수 - `ushort`, `uint`, `ulong`
      3. [유니코드 문자](https://learn.microsoft.com/ko-kr/dotnet/standard/base-types/character-encoding-introduction) - UTF-16 코드 단위
      4. [이진 부동 소수점](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types) - `double`
      5. 고정밀 10진수 부동소수점
      6. boolean - `bool`
    * [열거 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/enum) - enum E {}
    * [구조체 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/struct) - struct S {}
    * [Nullable 값 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/nullable-value-types) - 자료형 뒤 ?
    * [튜플 값 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/value-tuples) - (T1, T2, ...)
  
  * [참조 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/reference-types)
    * [클래스 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/class)
    * [인터페이스 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/interface)
    * [배열 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/arrays/)
    * [대리자 형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/reference-types#the-delegate-type) - delegate int D(...)


### 프로그램 구조
* 주요 조직 개념
  * [프로그램](https://learn.microsoft.com/ko-kr/dotnet/csharp/fundamentals/program-structure/)
  * [네임스페이스](https://learn.microsoft.com/ko-kr/dotnet/csharp/fundamentals/types/namespaces)
  * [형식](https://learn.microsoft.com/ko-kr/dotnet/csharp/fundamentals/types/)
  * [멤버](https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/classes-and-structs/members)
  * [어셈블리](https://learn.microsoft.com/ko-kr/dotnet/standard/assembly/)


* 관계
  * 프로그램 == 멤버를 포함 -> 네임스페이스로 구성될 형식을 선언
  * 형식 == 클래스, 구조체, 인터페이스
  * 멤버 == 필드, 메서드, 속성, 이벤트
  * 어셈블리 == C# 컴파일 => IL => JIT => 프로세서에 맞는 기계어로 변경 => 실행