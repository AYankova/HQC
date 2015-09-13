#     Структурни шаблони за дизайн
##    State Pattern
### Цел на шаблона
Позволява един обект да промени поведението си при промяна на текущото състояние. 

### Приложимост
*	Когато даден обект има сравнително малко на брой състояния като в даден момент може да бъде само в едно от тях и трябва да се извършват преходи от едно състояние в друго по време на изпълнението на програмата. 
*	Всяка операция на този обект съдържа логика за разклонение чрез използването на оператор за условен преход (if, switch),  като моментното състояние се описва чрез една или повече локални променливи и техните текущи стойности. Често едно и също разклонение се среща в повече от една операция на този обект.  

### Участници
*	Контекст (Context) – дефинира интерфейс за ползване за клиентите на този клас.
*	Състояние (State) – дефинира базов интерфейс описващ операциите, които се поддържат във всички състояния на обекта. 
*	Класове, представящи конкретни състояния (ConcreteState classes) – всеки такъв клас описва едно конкретно състояние и е имплементация на специфичната логика в това състояние.  

### Взаимодействия
Контекстът е основния публичен „интерфейс“ за кода използващ имплементацията на шаблона отвън. Той използва състоянието (базовия интерфейс), за да извиква зависимите от състоянието операции и може да се подава като аргумент на състоянието при необходимост. Преходите от едно състояние в друго и съответно подмяната на една конкретна имплементация на състояние с друга може да става както в контекста така и в класовете, представящи конкретни състояния.  

### Оценка на шаблона
Особености на шаблона:

*	Различните поведения се отделят в един клас за всяко състояние като по този начин всяко състояние има „обектен“ статус. От една страна се губи монолитността на архитектурата чрез използване на много конкретни класове, но от друга се избягва използването на тежка група от логически оператори за преход в кода на контекста.   
*	Използването на класове прави текущото състояние още по видимо спрямо използването на локални променливи. Допълнително предимство е също, че обектът не може да изпадне в невалидно състояние - например, ако състоянието се описва от група променливи и някоя комбинация от стойности не е валидно състояние.  
*	Ако класовете представящи конкретни състояния нямат полета, то състоянията могат да се преизползват (Flyweight). 

### Реализация
*	Шаблонът не дефинира къде се извършват преходи от едно състояние в друго – преходите могат да се извършват както в контекста така и в конкретните състояния. Преходи в конкретните състояния е в известен смисъл по-гъвкаво решение, защото лесно могат да се добавят нови състояния, но от друга страна изисква състоянията да знаят за други състояния и това създава свързаност между тях. 
*	Алтернатива на този шаблон е използването на таблица на преходите, която представлява списък от състоянията и възможните преходи. По този начин условните оператори се заменят с търсене на ключ в таблицата. Негативни страни са по-лошо бързодействие заради търсенето по ключ в таблица, по-трудната разбираемост на кода и по-трудното добавяне на код при минаването от едно състояние в друго (код, който трябва да се изпълни при самия преход). От друга страна, ако дадена операция не се поддържа в текущото състояние, не е очевидно, че тя не може да бъде изпълнена, както е при таблицата на преходите и крайните автомати в общия случай.  
В теоретичната информатика тази структура на практика представя краен автомат.  
*	Възможна е голяма гъвкавост при определяне на начина, по който се създават и трият обектите на състояния. Те могат да се създават само веднъж и да не се трият или пък могат да се създават динамично при нужда и дори да се трият, ако не са нужни повече. За определяне на подхода на управление е важно да се вземе предвид дали състоянието се сменя често и дали обектите на състоянията са тежки. 
*	Съществуват езици поддържащи динамично наследяване, при които може да се промени класът на даден обект по време на изпълнението на програмата. При тях на практика шаблона Състояние (State) е част от самия език. 

### Свързани шаблони
* „Миниобект“ (Flyweight) 
* „Сингълтон“ (Singleton)

