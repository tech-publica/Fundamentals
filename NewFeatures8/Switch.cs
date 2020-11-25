class ShowSwitchExpression 
{
  void MyMethod() 
  {
    int cardNumber = 12;
    string cardName = cardNumber switch 
    {
      13 => "King",
      12 => "Queen",
      11 => "Jack",
      _ => "Pip card" // equivalent to 'default'
    };
  }
}