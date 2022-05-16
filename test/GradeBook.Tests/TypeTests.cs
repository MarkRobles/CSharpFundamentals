using Xunit;

namespace GradeBook.Tests;

public class TypeTests
{


[Fact]
public void StringBehaveLikeValueTypes()
{

  string name= "Marcos";
  var upper = MakeUppercase(name);

  Assert.Equal("Marcos",name);  
  Assert.Equal("MARCOS",upper);

}


private string MakeUppercase(string parameter)
{
return parameter.ToUpper();
}

[Fact]
  public void ValueTypesPassedByRef()
  {
    var x= GetInt();
 
    SetInt(ref x);
    Assert.Equal(42,x);

  }

  private void SetInt(ref int x)
  { 
       //if you use out besides ref, you must assign a value to x. 
   x=42;
  }

  [Fact]
  public void ValueTypesAlsoPassByValue()
  {
    var x= GetInt();
    SetInt(x);
    Assert.Equal(3,x);

  }


private void SetInt(int x)
  {
   x=42;
  }
  private int GetInt()
  {
    return 3;
  }

   [Fact]
    public void CSsharpCanPassByRef()
    {
      //arrange
      var book1 = GetBook("Book1");
      GetBookSetName(ref book1,"New Name");
      //act

      //asert
      Assert.Equal("New Name",book1.Name);

    }
    
private void GetBookSetName(ref Book book,string name)
{
book= new Book(name);

}

   [Fact]
    public void CSsharpIsPassByValue()
    {
      //arrange
      var book1 = GetBook("Book1");
      GetBookSetName(book1,"New Name");
      //act

      //asert
      //What do you expect to find?
      Assert.Equal("Book1",book1.Name);

    }
    
private void GetBookSetName(Book book,string name)
{
book= new Book(name);

}
 [Fact]
    public void CanSetNameFromReference()
    {
      //arrange
      var book1 = GetBook("Book1");
      SetName(book1,"New Name");

 
      //act

      //asert
      Assert.Equal("New Name",book1.Name);

    }
    
private void SetName(Book book,string name)
{
book.Name = name;

}

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
      //arrange
      var book1 = GetBook("Book1");
      var book2 = GetBook("Book2");

 
      //act

      //asert
      Assert.Equal("Book1",book1.Name);
      Assert.Equal("Book2",book2.Name);
      Assert.NotSame(book1,book2);
    }
    

    
    [Fact]
    public void TwoVariablesCanReferenceSameObject()
    {
      //arrange
      var book1 = GetBook("Book1");
      //it is not a copy of book1 object, it just store the same value that is a pointer/reference to the same object 
      var book2 = book1;

 
      //act

      //asert
      //Way one
      // Assert.Equal("Book1",book1.Name);
      // Assert.Equal("Book1",book2.Name);
      //Way two
        Assert.Same(book1,book2);
        //Way 3
        Assert.True(object.ReferenceEquals(book1,book2));

    }
    Book GetBook(string name)
    {
return new Book(name);

    }
}