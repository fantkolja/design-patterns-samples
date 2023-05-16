namespace DesignPatterns.State
{
  interface IState
  {
    void Initiate();
    void End();
  }
} 





// Version #2 with Context passed as an arg
// namespace DesignPatterns.State
// {
//   interface IState
//   {
//     void Initiate();
//     void End(ClassicContext ctx);
//   }
// } 