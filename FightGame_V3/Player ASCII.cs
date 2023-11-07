public class Player_ASCII
{
    public static void Draw(Fighter fighter)
    {
        int currentRow;
        if (fighter.name == "Owen")
        {
            var rows = @"                         
        . ..*            
      ,*, *,***          
      ,/*,//(**          
        *(,..*           
   ,/*((,.(@,#/#         
   .*/%##((*(&(&%        
   ((((#% #   /@&,       
   %(((##&#(#(#%(@&.     
  .&&#(#&,%###,#%&@&%    
  &@#(/(*%@&@@@@#/(@&%   
  @@%((/%&@@&%@##&., &.  
  *@% *#(%&@@@@&(@     .,
   //.,*#(&@@@@((&#    . 
   %&&,/*(#@@@@((#&      
   &&@((%*#@@@@/(&&      
   %&&*(#*(@&%@*/%&      
    %&.##,,@#%@,(*%/     
  ,  #.,(/*@##%(,,*&     
  (, *..((  ((#(.,/(     
  /. .%##/  %@&&(,/*     
   ,( ...   ,/. ./,%     
  *%    .  ...*   .      
     ,  .. ....  .       
      .,.                ".Split("\n");
            currentRow = (int)(Console.WindowHeight * 0.3);
            foreach (string row in rows)
            {
                Console.SetCursorPosition((int)(Console.WindowWidth * 0.1), currentRow);
                Console.WriteLine(row);
                currentRow++;
            }
        }

        else
        {
            var rows = @"              (               
         .@ &@%              /
       ,@@%(#, .            #(
     /& (*%,#*(&&&/        *%(
   . /#&#/,&&/#%@#.        ,//
   %&##&@#&&//*&%           ,,
  %%#@& (%%(/%&              *
   /&@@% (%@%#*#*           *&
  @%@%&# (.,   &   /, .#@* .  
   @&(         .&@@@@&%&,,,   
  @@@@#@/&%#%&#&@@@&&.        
#@#@(  %&@@&&@%%&&%&%(   .%&&&
%,    .%%@&&&&&, (%,     %&@%.
  .*, &&#%&&*(&@*       &&%&  
       @%%#@      ,(/&#@@@&@% 
        @@     *%%##&%##&  &&%
             *%&@@##/,@*   ,%%
            %  @@#         , %
              &%#             
            ..%%              
            ,%.               ".Split("\n");
            currentRow = (int)(Console.WindowHeight * 0.35);
            foreach (string row in rows)
            {
                Console.SetCursorPosition((int)(Console.WindowWidth * 0.1), currentRow);
                Console.WriteLine(row);
                currentRow++;
            }
        }
    }
}
