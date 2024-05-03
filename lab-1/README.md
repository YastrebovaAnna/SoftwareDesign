# Дотримані принципи програмування 

##DRY - (Don't repeat yourself):
Принцип полягає в тому, щоб не було фрагментів коду, які повторюються. В класах, які були мною реалізовані, цей принцип дотримується. На приклад в класі [`Money`](./AppAboutMoney_Product/ClassLibrary/Money.cs#L14) фрагмент коду, який відповідає за перевірку правильності встановлених значень було винесено в окремий метод, задання значень частин також було винесено в окремий [метод](./AppAboutMoney_Product/ClassLibrary/Money.cs#L22). В класі [`Warehouse`](./AppAboutMoney_Product/ClassLibrary/Warehouse.cs#L14). В усіх інших класах нема фрагментів коду, які б могли повторюватись.


##KISS - (Keep it simple, stupid):
Принцип дотримано. Всі класи прості та містять зрозумілий код. Єдиний метод, який [може здатись завеликим чи заважким](./AppAboutMoney_Product/ClassLibrary/Money.cs#L29), але в методі необхідні дані перевірки та обрахунки, оскільки нові встановлені значення без них можуть бути невірними. 


##Fail Fast - падай швидко:
Принип дотримано в класах. На приклад в класі [`Money`](./AppAboutMoney_Product/ClassLibrary/Money.cs#L14), [`WarehouseProduct`](./AppAboutMoney_Product/ClassLibrary/WarehouseProduct.cs#L18), [`Warehouse`](./AppAboutMoney_Product/ClassLibrary/Warehouse.cs#L14), [`Reporting`](./AppAboutMoney_Product/ClassLibrary/Reporting.cs#L11).


##YAGNI - (You Aren't Gonna Need It):
Принцип дотримано в класах. Методи які реалізовані є необхідними та вимагаються завданням.


## SOLID:
- Single Responsibility Principle:
Всі класи відповідають принципу єдиного обов'язку. Клас [Money](./AppAboutMoney_Product/ClassLibrary/Money.cs#L3) відповідає за управління станом об'єкта грошей; [Warehouse](./AppAboutMoney_Product/ClassLibrary/Warehouse.cs#L6) управляє інвентарем; [WarehouseProduct](./AppAboutMoney_Product/ClassLibrary/WarehouseProduct.cs#L9) слугує контейнером для даних про продукт. [`Product`](./AppAboutMoney_Product/ClassLibrary/Product.cs#L9) відповідає за інформації про продукт. Також було створено окремий клас [FormatHelper](./AppAboutMoney_Product/ClassLibrary/FormatHelper.cs#L9), який забезпечує форматування.

- Open/Closed Principle:
Класи [Money](./AppAboutMoney_Product/ClassLibrary/Money.cs#L3), [Product](./AppAboutMoney_Product/ClassLibrary/Product.cs#L9), [Warehouse](./AppAboutMoney_Product/ClassLibrary/Warehouse.cs#L6), [WarehouseProduct](./AppAboutMoney_Product/ClassLibrary/WarehouseProduct.cs#L9) можуть бути розширеними, але існуючий код не потребує змін.

- Liskov Substitution Principle:
Клас [UAH](./AppAboutMoney_Product/ClassLibrary/UAH.cs#L9) успадковує від Money та може бути використаний там, де очікується об'єкт типу Money. UAH може замінити клас Money без зміни поведінки програми. 

- Interface Segregation Principle:
[IMoney](./AppAboutMoney_Product/ClassLibrary/IMoney.cs#L9) визначає тільки необхідні методи для управління грошима.

- Dependency Inversion Principle:
Product - Залежить від абстракції IMoney. Reporting залежить від абстракції Warehouse


##Composition Over Inheritance: 
Використання IMoney як частини інших класів замість спадкування. Клас [Product](./AppAboutMoney_Product/ClassLibrary/Product.cs#L12), властивість Price типу IMoney є прикладом використання композиції. Product містить об'єкт IMoney, який може бути будь-яким класом, що реалізує інтерфейс IMoney. [WarehouseProduct](./AppAboutMoney_Product/ClassLibrary/WarehouseProduct.cs#L14) використовує композицію для інтеграції Product і властивості Price. 


##Program to Interfaces not Implementations:
Реалізований через використання інтерфейсу IMoney, який дозволяє класам взаємодіяти через абстракції замість конкретних реалізацій.

