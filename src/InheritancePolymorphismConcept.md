# Answer

Inheritance is an OO concept that allows you to encapsulate implementations in a base class to reuse those implementations in a derived class

Polymorphism is a concept that allows you to rewrite these implementations with different behaviors


# Inheritance and Polymorphism sample

```csharp

    public class Vehicle
    {
        private readonly bool _engineOn = false;

        protected int speed = 0;

        public void StartEngine()
        {
            _engineOn = true;
		}

        public void  TurnEngineOff() 
        {
            _engineOn - false;
		}

        public virtual void SpeedUp()
        {
            speed = speed + 1;
		}
    }

    public class Car : Vehicle
    {
        private readonly bool _engineOn = false;

        protected int speed = 0;

        
        public override void SpeedUp()
        {
            speed = speed + 10;
		}
    }
```