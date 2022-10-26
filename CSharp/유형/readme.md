# 유형

### C# 형식 및 멤버
* C#은 캡슐화, 상속, 다형성 개념을 지원함
* 클래스는 단일 부모 클래스에서 직접 상속가능 == 상속은 1개만
* 클래스는 원하는 수(다 수) 인터페이스를 구현 가능 == impl은 여러개 가능
* 구조체는 인터페이스를 구현할 수 있음
* 구조체는 상속을 할 수 없음. 스택 할당 형식
* 데이터 값을 저장하는 용도의 형식으로 `record struct`가 있음

### 클래스 및 개체
* 클래스는 상태(필드)와 작업(메서드 및 기타 함수 멤버)을 하나의 단위로 결합하는 데이터 구조
* 클래스(인스턴스 == 개체)에 대한 정의를 제공
* 클래스의 구조
  1. 클래스의 특성 및 한정자
  2. 클래스 이름
  3. 기본 클래스(상속 시)
  4. 구현하고 싶은 인터페이스
    ```csharp
        public class Point 
        {
            public int X { get; }
            public int Y { get; }
            public Point(int x, int y) => (X, Y) = (x, y);        
        }
    ```
    ```csharp
        var p1 = new Point(0, 0);
        var p2 = new Point(10, 20);
    ```
    * 만약 개체가 차지하는 메모리를 더 이상 참조하지 않는다면, GC에서 자동으로 회수
    * C#에서는 명시적으로 메모리 할당을 해제할 필요가 없음

### 형식 매개 변수
* 제네릭 클래스는 형식 매개 변수를 정의하여 사용
* 형식 매개 변수는 대괄호로 묶인 매개 변수의 이름 목록으로 작성
* 형식 매개 변수는 클래스 이름을 따름
   ```csharp
        public class Pair<TFirst, TSecond>
        {
            public TFirst First { get; }
            public TSecond Second { get; }
            public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);
        }
   ```
   ```csharp
        var pair = new Pair<int, String>(1, "one");
        int i = pair.First;
        string s = pair.Second;
   ```
* `제네릭 클래스 형식` : 형식 매개 변수를 사용하도록 선언된 클래스 형식
  * 구조체, 인터페이스 및 대리자 형식도 제네릭 가능
* `생성된 형식` : `Pair<int, string>`과 같이 형식 인수가 제공된 제네릭 형식

### 기본 클래스
* 클래스 선언은 기본 클래스를 지정할 수 있음(상속)
  * 상속은 클래스 이름 및 형식 매개 변수 뒤에 콜론(:)과 기본 클래스의 이름을 사용
  * 기본 클래스 지정을 생략하면 자동으로 `object` 상속
  ```csharp
       public class Point3D : Point
       {
           public int Z { get; set; }
           public Point3D(int x, int y, int z) : base(x, y)
           {
               Z = z;
           }
       }
  ```
  ```csharp
       Point a = new(10, 20);
       Point b = new Point3D(10, 20, 30); //부모 형식으로 받을 수 있음
  ```
* 클래스는 기본 클래스의 멤버를 상속
* 인스턴스 및 정적 생성자와 종결자는 상속하지 않음
* 파생 클래스는 해당 파생된 클래스를 상속하는 멤버에 새 멤버를 추가 가능
* 다만, 파생 클래스는 상속된 멤버의 저의를 제거할 수 없음

### 구조체
* 클래스는 상속과 다형성을 지원하는 형식의 정의
* 이를 통해 파생 클래스의 계층 구조를 기반으로 정교한 동작을 만들 수 있음
* 구조체 형식은 데이터 값을 저장하는 것이 주된 목적
* 구조체는 기본 형식을 선언할 수 없음
* `System.ValueType`에서 암시적으로 파생
* 구조체 형식에서 다른 구조체 형식으로 파생이 불가능하며 암시적으로 봉인
  ```csharp
       public struct Point
       {
         public double X { get; }
         public double Y { get; }
        
         public Point(double x, double y) => (X, Y) = (x, y);
       }
  ```
  
### 인터페이스
* 인터페이스는 클래스 및 구조체에서 구현할 수 있는 기능에 대한 정의
* 고유한 형식 간에 공유되는 기능을 선언하는 것
* 인터페이스는 메서드, 속성, 이벤트 및 인덱서를 포함할 수 있음
* 관례상 앞에 `I`를 붙여 파일을 생성
* 인터페이스는 `여러개의 상속`을 받을 수 있음
```csharp
interface IControl
{
    void Paint();
}

interface ITextBox : IControl
{
    void SetText(string text);
}

interface IListBox : IControl
{
    void SetItems(string [] items);
}

interface IComboBox : ITextBox, IListBox 
{
}
```

### 열거형
* 열거형식은 상수 값 집합
```csharp
public enum SomeRootVegetable
    HorseRadish,
    Radish,
    Turnip
```
* 플래그를 정의하여 `enum`활용
```csharp
[Flags]
public enum Seasons
{
    None = 0,
    Spring = 1,
    Summer = 2,
    Autumn = 4,
    Winter = 8,
    ALL = Srping | Summer | Autumn | Winter
}
```

### Nullable 유형
* 모든 형식의 변수는 nullable을 활용해 선언될 수 있음
* null 허용 변수는 값이 없음을 나타내는 `null`값을 가질 수 있음
* null 허용 값 형식(구조체, 열거형)은 `System.Nullable<T>`로 표현됨
* null을 허용하지 않는 형식과 null 참조 형식은 모두 기본 참조 형식으로 표현
* 컴파일러는 null 참조가 먼저 null에 대해 값을 검사하지 않음
  * `역참조`되는 값이라면 경고를 발생
```csharp
int? optionalInt = default; //null 
optionalInt = 5;
string? optionalText = default; //null
optionalText = "Hello World.";
``` 

### 튜플
* 간단한 데이터 구조에서 여러 데이터 요소를 그룹화를 위해 사용 
* `(`와 `)`사이에서 멤버의 형식과 이름을 선언함으로써 인스턴스화 시킴
```csharp
(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
```
* 튜플은 기본 구성 요소를 사용하지 않고도 여러 멤버를 위한 또 다른 데이터 구조를 제공할 수 있음
