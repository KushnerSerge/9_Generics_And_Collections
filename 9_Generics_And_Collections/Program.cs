// See https://aka.ms/new-console-template for more information

using _9_Generics_And_Collections;
using _9_Generics_And_Collections.Entities;
using _9_Generics_And_Collections.Presentation;

Experimenting_With_List();
//RepositoryPatternExperiment();



void RepositoryPatternExperiment()
{

    LikeController<Company> myController = new LikeController<Company>();
    // Post items
    Console.WriteLine("----------- Post Items -----------------");
    myController.POST(new Company { Id = 1, Name = "One Company", Rating = 4 });
    myController.POST(new Company { Id = 2, Name = "Two Company", Rating = 1 });
    myController.POST(new Company { Id = 3, Name = "Three Company", Rating = 4 });
    myController.POST(new Company { Id = 4, Name = "Four Company", Rating = 2 });
    myController.POST(new Company { Id = 5, Name = "Five Company", Rating = 3 });
    myController.POST(new Company { Id = 6, Name = "Six Company", Rating = 5 });
    myController.POST(new Company { Id = 7, Name = "Seven Company", Rating = 5 });


    Company[] companies = myController.GET_All_Items();
    Console.WriteLine("GET ALL ITEMS RESULT");
    foreach (Company company in companies)
    {
        if (company != null) Console.WriteLine(company.Name);
    }
    Console.WriteLine("------------------------------");

    // Get item by id
    Console.WriteLine("Get item by Id");
    Console.WriteLine("Item with Id 4 is: {0}", myController.GET_Ttem_By_Id(3).Name);


    // UPDATE ITEM
    Console.WriteLine("------------Update Company------------------");
    myController.UPDATE(3, new Company { Id = 4, Name = "FourCompanyUpdated", Rating = 5 });
    Console.WriteLine("Item with Id {0} UPDATED is: {1}", myController.GET_Ttem_By_Id(3).Id, myController.GET_Ttem_By_Id(3).Name);


    // Delete Item
    Console.WriteLine("------------Delete Item------------------");
    myController.DELETE(3);
    Console.WriteLine(myController.GET_Ttem_By_Id(3));
    Console.WriteLine("List All Companies");
    foreach (Company company in companies)
    {
        if (company != null) Console.WriteLine(company.Name);
    }

}


// ---------- Experimenting With List ---------------------------
void Experimenting_With_List()
{

    MyList<int?> myList = new MyList<int?>();
    for (int i = 0; i < 16; i++)
    {
        myList[i] = i;
    }
       
  
    foreach (var item in myList)
    {
        Console.WriteLine(item);
    }
    
    Console.WriteLine("------Swap 1 value with 10-----------------");
    myList.SwapByIndex(1, 10);
    foreach (var item in myList)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("------Swap 3 value with 8-----------------");
    myList.SwapByIndex(3, 8);
    foreach (var item in myList)
    {
        Console.WriteLine(item);
    }


    Console.WriteLine("current position: {0}", myList.currentPosition);
    Console.WriteLine("Length  --- is {0}", myList.Length());

    for (int i = 0; i < myList.Length(); i++)
    {
        Console.WriteLine("position {0}, we have {1}", i, myList[i]);
    }

    Console.WriteLine("At postions 7 we have {0}", myList[7]);
    myList.Delete(7);
    Console.WriteLine("At postions 7 we have {0}", myList[7]);
}
// ---------------------------  --------------------------------------------