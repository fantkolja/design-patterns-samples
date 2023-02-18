namespace DesignPatterns.State
{
  interface IClassicState
  {
    void Initiate();
    void End();
  }
} 





// Version #2 with Context passed as an arg
// namespace DesignPatterns.State
// {
//   interface IClassicState
//   {
//     void Initiate();
//     void End(ClassicContext ctx);
//   }
// } 