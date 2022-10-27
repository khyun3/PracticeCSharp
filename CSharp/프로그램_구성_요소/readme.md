# 프로그램 구성 요소

> 속성 : 필드, 메서드 및 이벤트와 같은 멤버<br/>
> 식 : 피연산자 및 연산자로 표현되는 연산<br/>
> 문 : 프로그램의 동작을 컨트롤

### 멤버
* 멤버(`class`)는 정적 멤버 또는 인스턴스 멤버가 있음
* 정적 멤버는 클래스에 속함
* 인스턴스 멤버는 개체에 속함

| 멤버         | 설명                                  |
|------------|-------------------------------------|
| 상수         | 클래스와 연결된 상수 값                       |
| 필드         | 클래스와 연결된 변수                         |
| 메서드        | 클래스에서 수행할 수 있는 작업                   |
| Properties | 클래스의 명명된 속성에 대한 읽기 및 쓰기와 관련된 작업     |
| 인덱서        | 클래스 인스턴스를 배열처럼 인덱싱하는 것과 관련된 작업      |
| 이벤트        | 클래스에 의해 생성될 수 있는 알림                 |
| 연산자        | 클래스가 지원하는 변환 및 식 연산자                |
| 생성자        | 클래스의 인스턴스 또는 클래스 자체를 초기화하는 데 필요한 작업 |
| 종료자        | 클래스의 인스턴스가 영구적으로 삭제되기 전에 수행한 작업     |
| 형식         | 클래스에 의해 선언된 중첩 형식                   |

### 접근성
* 클래스의 각 멤버에는 해당 멤버에 액세스할 수 있는 프로그램 텍스트의 영역을 제어하는 액세스 수준이 있음
* 총 6가지 형태로 제공됨 이를 `액세스 한정자`라고 부름

| 멤버                 | 설명                                                   |
|--------------------|------------------------------------------------------|
| public             | 액세스가 제한되지 않음                                         |
| private            | 이 클래스로만 액세스가 제한됨                                     |
| protected          | 이 클래스 또는 이 클래스에서 파생된 클래스로만 액세스가 제한됨                  |
| internal           | 액세스가 현재 어셈블리(.exe 또는 .dll)로 제한됩니다.                   |
| protected internal | 액세스가 이 클래스, 이 클래스에서 파생된 클래스 또는 동일한 어셈블리 내의 클래스로만 제한됨 |
| private protected  | 액세스가 이 클래스 또는 동일한 어셈블리 내의 이 형식에서 파생된 클래스로만 제한됨       |

### 필드
* 필드는 클래스 또는 클래스의 인스턴스와 연결된 변수
* `static`한정자를 사용하여 선언된 필드는 `정적 필드`라 함
  * 정적 필드는 정확히 하나의 스토리지 위치를 식별함
  * 클래스의 이스턴스가 몇 개나 만들어졌는지에 관계없이 정적 필드의 복사본은 하나
* `static`한정자 없이 선언된 필드를 `인스턴스 필드`라 함
  * 클래스의 모든 인스턴스는 해당 클래스의 모든 인스턴스 필드의 별도 복사본을 포함
```csharp
public class Color
{
    public static readonly Color Black = new(0, 0, 0);
    public static readonly Color White = new(255, 255, 255);
    public static readonly Color Red = new(255, 0, 0);
    public static readonly Color Green = new(0, 255, 0);
    public static readonly Color Blue = new(0, 0, 255);
    
    public byte R;
    public byte G;
    public byte B;

    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }
}
```
* 읽기 전용 필드는 `readonly` 한정자를 사용하여 선언
  * 읽기 전용 필드의 할당은 `필드 선언의 일부` 또는 `생성자`에서만 가능

### 메서드
* 메서드는 개체 또는 클래스에서 수행할 수 있는 계산이나 작업을 구현하는 멤버
* 정적 메서드는 클래스를 통해 액세스
* 인스턴스 메서드는 클래스의 인스턴스를 통해 액세스
* `매개 변수` : 메서드에는 메서드로 전달되는 값 또는 변수 참조를 나타내는 목록
* `반환 형식` : 메서드에 의해 계산되고 반환되는 값의 형식
* 형식과 마찬가지로 메서드에는 메서드가 호출될 때 형식 인수가 지정되어야 하는 형식 매개 변수 집합도 있을 수 있음
* 형식과 달리 형식 인수는 종종 메서드 호출의 인수에서 유추될 수 있으므로 명시적으로 지정할 필요가 없음
* `시그니처` : 메서드가 선언되는 클래스에서 고유함을 나타낼 수 있는 집합
  * `메서드의 이름`, `형식 매개 변수의 수`, `해당 매개 변수의 수`, `한정자 및 형식`으로 구성
  * 반환 형식은 포함하지 않음
```csharp
public override string ToString() => "This is an object";
```
* 메서드의 본문이 단일식(1줄)일 경우 위와 같이 간결하게 식 형식을 사용하여 정의 가능

### 매개 변수
* 매개 변수는 매서드에 값 또는 변수 참조를 전달하는 역할
* 메서드가 호출될 때 지정된 인수에서 실제 값을 가져옴
* 종류 : `값 매개 변수`, `참조 매개 변수`, `출력 매개 변수`, `매개 변수 배열`
* `값 매개 변수`
  * 입력 매개 변수를 전달하는 데 사용
  * 값 매개 변수는 전달된 인수에서 초기 값을 가져오는 지역 변수에 해당
  * 즉, 값 매개 변수를 수정해도 해당 매개 변수에 전달된 인수에 영향을 주지 않음
* `참조 매개 변수`
  * 인수를 참조로 전달하는 데 사용
  * 메서드를 실행하는 동안 참조 매개 변수는 인수 변수와 동일한 스토리지 위치를 나타냄
  * `ref`한정자 사용하여 선언
```csharp
static void Swap(ref int x, ref int y)
{
  int temp = x;
  x = y;
  y = temp;
  //tuples를 사용하면 더 간단하게 변경할 수 있음
  //(x, y) = (y, x);
}
```
* `출력 매개 변수`
  * 인수를 참조로 전달하는 데 사용
  * 호출자가 제공한 인수에 값을 명시적으로 할당할 필요가 없다는 점을 제외하면 참조 매개 변수와 비슷함
  * `out`한정자를 사용하여 선언
```csharp
static void divide(int x, int y, out int quotient, out int remainder)
{
    qutient = x / y;
    remainder = x % y;
}
```
*`매개 변수 배열`
  * 다양한 개수의 인수가 메서드에 전달되도록 허용
  * `params`한정자를 사용하여 선언
  * 마지막 매개 변수만 매개 변수 배열일 수 있으며 배열의 형식은 1차원 배열 형식
    * JAVA의 ...
  * 좋은 예 : `System.Console` 클래스의 Write 및 WriteLine 메서드
```csharp
public class Console
{
    public static void Write(string fmt, params object[] args) {}
    public static void WriteLine(string fmt, params object[] args) {}
}

int x, y, z;
x = 3;
y = 4;
z = 5;
Console.WriteLine("Hello"); //단일 인수 전달
Console.WriteLine("x={0} y={1} z={2}", x,y,z); //임의 개수의 요소 형식 인수 전달
//result : x=3 y=4 z=5
string fmt = "x={0} y={1} z={2}";
object[] args[] new object[3];
args[0] = 3;
args[1] = 4;
args[2] = 5;
Console.WriteLine(s, args);
//result : x=3 y=4 z=5
```
* 메서드 내에서 매개 변수 배열은 배열 형식의 일반 매개 변수와 정확히 동일하게 동작
* 매개 변수 배열을 사용한 메서드 호출 
  * 단일 인수 전달
  * 임의 개수의 요소 형식 인수 전달
* 후자의 경우 지정된 인수를 사용하여 배열 인스턴스가 자동으로 만들어지고 초기화 됨


### 메서드 본문 및 지역 변수
* 메서드 본문은 메서드가 호출될 때 실행할 문(로직)을 지정
* 메서드 본문은 메서드 호출과 관련된 변수를 선언할 수 있음
```csharp
class Squares
{
    public static void WriteSquares() 
    {
        int i = 0;
        int j;
        while(i < 10) 
        {
            j = i*i;
            Console.WriteLine($"{i} x {i} = {j}");
            i++;
        }
    }
}
```
* C#에서는 해당 값을 얻기 위해 먼저 로컬 변수를 명확 하게 할당해야 함
  * 위 코드에서 i의 선언이 초기 값을 포함하지 않으면 컴파일러는 i의 후속 사용에 대해 오류를 보고함
* 메서드는 return으로 호출자에게 컨트롤을 반환할 수 있음


### 정적 및 인스턴스 멧드
* `static` 한정자를 사용하여 선언된 메서드는 `정적 메서드`라고 함
  * 특정 인스턴스에 작동하지 않고 정적 멤버에 직접적으로만 액세스 할 수 있음
* `static` 한정자를 사용하지 않고 선언된 메서드는 `인스턴스 메서드`라고 함
  * 특정 인스턴스에 작동
  * 정적 및 인스턴스 멤버 둘 다에 액세스 가능
  * this로 명시적 액세스가 가능
  * 단, 정적 메서드에서 this는 사용이 불가능함(인스턴스 개체가 아니기 때문)
```csharp
class entity
{
    static int s_nextSerialNo;
    int _serialNo;
    
    public Entity()
    {
        _serialNo = s_nextSerialNo++;
    }
    
    public int GetSerialNo()
    {
        return _serialNo;
    }
    
    public static int GetNextSerialNo()
    {
        return s_nextSerialNo;
    }
    
    public static void SetNextSerialNo(int value)
    {
        s_nextSerialNo = value;
    }
}
```
```csharp
Entity.SetNextSerialNo(1000);
Entity e1 = new();
Entity e2 = new();
Console.WriteLine(e1.GetSerialNo());
Console.WriteLine(e2.GetSerialNo());
Console.WriteLine(Entity.GetNextSerialNo());
```
* 각 `Entity` 인스턴스에는 일련 번호가 포함
* `Entity` 생성자는 사용 가능한 다음 일련 번호를 사용하여 새 인스턴스 초기화
* 생서자가 인스턴스 멤버이므로 _serialNo 인스턴스 필드 및 s_nextSerialNo 정적 필드 둘다에 액세스하도록 허용되어 있음
* GetNextSerialNo, SetNextSerialNo는 정적 메서드이므로 s_nextSerialNo 정적 필드에 액세스 가능
  * 인스턴스 필드인 SerialNo에 직접 액세스는 불가능

### 가상, 재정의 및 추상 메서드
* 클래스 형식의 계층 구조에 대한 동작을 정의하기 위해 사용
* 클래스는 기본 클래스에서 파생될 수 있기 때문에 기본 클래스에서 구현된 동작을 수정가능 해야 함
* 가상 메서드는 파생 클래스가 보다 구체적인 구현을 제공할 수 있는 기본 클래스에서 선언됨
* `재정의` 메서드는 기본 클래스 구현의 동작을 수정하는 파생 클래스에서 구현되는 메서드
* 추상 메서드는 모든 파생 클래스에서 재정의 해야 하는 기본 클래스에서 선언된 메서드
* 실제 구현은 기본 클래스에서 하지 않음

* 인스턴스 메서드에 대한 메서드 호출은 기본 클래스 또는 파생 클래스 구현으로 확인 가능
* 변수의 형식은 `컴파일 시간 형식`을 결정
  * `컴파일 시간 형식` : 컴파일러가 해당 멤버를 확인하는 데 사용하는 형식
  * `런타임 형식` : 변수가 참조하는 실제 인스턴스의 형식
* 가상 메서드가 호출되면 호출이 발생하는 인스턴스의 `런타임 형식`에 따라 호출할 실제 메서드 구현이 결정됨
* 비가상 메서드 호출에서는 인스턴스의 `컴파일 타임 형식`이 결정 요인
* `가상 메서드`는 파생된 클래스에서 재정의 될 수 있음
* `추상 메서드`는 구현이 없는 가상 메서드
  * `abstract`한정자를 사용하여 선언
  * 추상 클래스에서만 허용
  * 추상 메서드는 모든 비추상 파생 클래스에서 재정의가 강제됨
```csharp
public abstract class Expression
{
    public abstract double Evaluate(Dictionary<string, object> vars);
}

public class Constant : Expression
{
    double _value;
    
    public Constant(double value) => (_vaule) = (vlaue);
    
    public override double Evaluate(Dictionary<string, object> vars)
    {
        return _value;
    }
}
public class VariableReference : Expression
{
    string _name;
    
    public VariableReference(string name)
    {
        _name = name;
    }
    
    public override double Evaluate(Dictionary<string, object> vars)
    {
        object value = vars[_name] ?? throw new Exception($"Unknown variable : {_name}");
        return Convert.ToDouble(value);
    }
}

public class Operation : Expression
{
    Expression _left;
    char _op;
    Expression _right;
    
    public Opreation(Expression left, char op, Expression right) => 
        (_left, _op, _right) = (left, op, right);
    
    public override double Evaluate(Dictionary<string, object> vars)
    {
        double x = _left.Evaluate(vars);
        double y = _right.Evaluate(vars);
        switch(_op)
        {
            case "+": return x + y;
            case "-": return x - y;
            case "*": return x * y;
            case "/": return x / y;
            
            default: throw new Exception("Unkonow operator");
        }
    }
}
```
* `Expression`의 `Evaluate` 메서드는 추상 메서드이기 떄문에 파생된 비추상 클래스에서 재정의 해야 함
```csharp
Expression e = new Operation(
    new VariableReference("x"),
    '*',
    new Operation(
        new VariableReference("y"),
        '+',
        new Constant(2)
    )
);
Dictionary<string, object> vars = new();
vars["x"] = 3;
vars["y"] = 5;
Console.WriteLine(e.Evaluate(vars)); // "21"
vars["x"] = 1.5;
vars["y"] = 9;
Console.WriteLine(e.Evaluate(vars)); // "16.5"
//x * (y + 2) 계산
```

### 메서드 오버로드
* 메서드 오버로드는 동일한 클래스가 고유한 시그니처를 갖는 한, 동일한 이름을 갖도록 허용하는 것
* 오버로드된 메서드의 호출을 컴파일할 때 컴파일러는 오버로드 확인을 사용하여 호출할 특정 메서드를 결정
* 오버로드 확인은 인수와 가장 적합하게 일치하는 단일 메서드를 찾음
```csharp
class OverloadingExample
{
    static void F() => Console.WriteLine("F()");
    static void F(object x) => Console.WriteLine("F(object)");
    static void F(int x) => Console.WriteLine("F(int)");
    static void F(double x) => Console.WriteLine("F(double)");
    static void F<T>(T x) => Console.WriteLine($"F<T>(T), T is {typeof(T)}");            
    static void F(double x, double y) => Console.WriteLine("F(double, double)");
    
    public static void UsageExample()
    {
        F();            // Invokes F()
        F(1);           // Invokes F(int)
        F(1.0);         // Invokes F(double)
        F("abc");       // Invokes F<T>(T), T is System.String
        F((double)1);   // Invokes F(double)
        F((object)1);   // Invokes F(object)
        F<int>(1);      // Invokes F<T>(T), T is System.Int32
        F(1, 1);        // Invokes F(double, double)
    }
}
```

### 기타 함수 멤버
* 실행 코드를 포함하는 멤버를 통칭하여 클래스의 함수 멤버라고 함
* 함수 멤버에는 `메서드`, `생성자`, `속성`, `인덱서`, `이벤트`, `연산자`, `종료자`가 있음
```csharp
public class MyList<T>
{
    const int DefaultCapacity = 4;

    T[] _items;
    int _count;
    
    //인스턴스 생성자
    public MyList(int capacity = DefaultCapacity)
    {
        _items = new T[capacity];
    }

    public int Count => _count;

    public int Capacity
    {
        get =>  _items.Length;
        set
        {
            if (value < _count) value = _count;
            if (value != _items.Length)
            {
                T[] newItems = new T[value];
                Array.Copy(_items, 0, newItems, 0, _count);
                _items = newItems;
            }
        }
    }

    public T this[int index]
    {
        get => _items[index];
        set
        {
            _items[index] = value;
            OnChanged();
        }
    }

    public void Add(T item)
    {
        if (_count == Capacity) Capacity = _count * 2;
        _items[_count] = item;
        _count++;
        OnChanged();
    }
    protected virtual void OnChanged() =>
        Changed?.Invoke(this, EventArgs.Empty);

    public override bool Equals(object other) =>
        Equals(this, other as MyList<T>);

    static bool Equals(MyList<T> a, MyList<T> b)
    {
        if (Object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);
        if (Object.ReferenceEquals(b, null) || a._count != b._count)
            return false;
        for (int i = 0; i < a._count; i++)
        {
            if (!object.Equals(a._items[i], b._items[i]))
            {
                return false;
            }
        }
        return true;
    }

    public event EventHandler Changed;

    public static bool operator ==(MyList<T> a, MyList<T> b) =>
        Equals(a, b);

    public static bool operator !=(MyList<T> a, MyList<T> b) =>
        !Equals(a, b);
}
```
* 생성자
  * C#은 인스턴스 및 정적 생성자를 모두 지원함
  * `인스턴스 생성자`는 클래스의 인스턴스를 초기화하는 데 필요한 작업을 구현하는 멤버
  * `정적 생성자`는 처음 로드될 때 클래스 자체를 초기화하는 데 필요한 동작을 구현하는 멤버
  * 생성자는 반환 형식이 없고 포함하는 클래스와 이름이 동일함
  * `static` 한정자가 포함될 경우 정적 생성자를 선언
  * `인스턴스 생성자`는 오버로드 될 수 있으며 선택적 매개 변수를 가질 수 있음
  * `인스턴스 생성자`는 상속되지 않음
  * 클래스에 실제 선언된 인스턴스 생성자외에는 인스턴스 생성자가 없음
  * 인스턴스 생성자를 제공하지 않았다면 빈 생성자를 자동으로 제공

* 속성
  * 필드의 기본 확장
  * 속성, 필드는 연결된 형식으로 명명되는 멤버
  * 필드 및 속성에 액세스하는 구문은 동일
  * 필드와 달리 속성은 스토리지 위치를 명시하지 않음 대신, 속성에는 해당 값을 읽거나 쓸 때 실행될 문을 지정하는 `접근사`를 사용
  * 접근자 : `get`, `set`
  * 