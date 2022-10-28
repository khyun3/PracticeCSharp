using System;
using System.Collections.Specialized;

namespace CSharp.프로그램_구성_요소
{
    public class MyList<T>
    {
        private const int DefaultCapacity = 4;

        private T[] _items;
        private int _count;

        // 커스텀 생성자
        public MyList(int capacity = DefaultCapacity) => _items = new T[capacity];

        public int Count => _count;

        public int Capacity
        {
            //접근자
            get => _items.Length; //값을 읽는 접근자 get
            set                   //값을 설정하는 접근자 set
            {
                if (value < _count)
                {
                    value = _count;
                }

                if (value != _items.Length)
                {
                    var newItems = new T[value];
                    Array.Copy(_items, 0, newItems, 0, _count);
                    _items = newItems;
                }
            }
        }

        //indexer
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
            if (_count == Capacity)
            {
                Capacity = _count * 2;
            }

            _items[_count] = item;
            _count++;
            OnChanged();
        }

        //속성의 접근자는 가상일 수 있습니다.
        //속성 선언에 virtual, abstract, 또는 override 한정자가 포함되면 속성의 접근자에 적용
        protected virtual void OnChanged() =>
            Changed?.Invoke(this, EventArgs.Empty);

        public override bool Equals(object other) =>
            Equals(this, other as MyList<T>);

        static bool Equals(MyList<T> a, MyList<T> b)
        {
            if (ReferenceEquals(a, null))
            {
                return ReferenceEquals(b, null);
            }

            if (ReferenceEquals(b, null) || a._count != b._count)
            {
                return false;
            }

            for (int i = 0; i < a._count; i++)
            {
                if (!Equals(a._items[i], b._items[i]))
                {
                    return false;
                }
            }

            return true;
        }

        //이벤트는 선언에 event 키워드가 포함되고 형식이 대리자 형식이어야 한다는 점을 제외하고 필드처럼 선언
        public event EventHandler Changed;

        //연산자
        public static bool operator == (MyList<T> a, MyList<T> b) => Equals(a, b);
        public static bool operator !=(MyList<T> a, MyList<T> b) => !Equals(a, b);
    }
}