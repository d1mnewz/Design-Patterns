Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

<img src = "http://www.oodesign.com/images/creational/abstract-factory-pattern.png"/>

AbstractFactory class declares only an interface for creating the products. The actual creation is the task of the ConcreteProduct classes, where a good approach is applying the Factory Method design pattern for each product of the family.
Extending factories can be done by using one Create method for all products and attaching information about the type of product needed.


<b>My Sample from real life:</b>

Many IT-companies are looking for clever students that are ready to work. 

University provides an opportunity to find them. 

Let`s imagine the situation where we`ve got SoftServe and Silego Inc (engineering company).

They are looking for interns. 

So we can can create an IFaculty interface as abstract factory that can GetStudent() according to speciality.

Then we create a EngiFactory that will return only engineers. And ProgFactory that will return only programmers.


Well done, now we can simplify our code. 

			IFaculty progs = new ProgFactory();  // this factory will return only programmers
			
            Console.WriteLine(progs.GetStudent().desc);

            IFaculty engs = new EngiFactory(); // this factory will return only engineers
			
            Console.WriteLine(engs.GetStudent().desc);
			
These pieces of code are almost identic pizda 