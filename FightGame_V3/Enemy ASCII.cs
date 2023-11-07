using System.Data;

public class Enemy_ASCII
{
    public static void Draw(Fighter fighter)
    {
        int currentRow;
        if(fighter.name == "Tagilla")
        {
            var rows = @"                                             
                 ,%%(                        
               ..  ,**&                      
               *///*#(#*                     
               **##%%%&*                     
               /(%,//%*(% *                  
           .   .* *.  ,(          %&&&%%%    
          ,     ,,./*,*% (          *(%&&%(  
          ( *  (/(/*(/%#*%(.(/.  #/&,        
          *   .*(((((&#(,  .,../*(/*         
                  //((((    *..              
            *%%&/,*#**(((*(*                 
         #&&%##(#%%%%#/ /,&                  
        %&%#(#%&&&&&%.&&##((                 
         %&&#&&  %/*   &&%(/(,               
       /##%#&&&#,       %&&%#**              
      .%(#%%&@,          %&&%*/              
       &#%&&#            #%%(#/              
        &#&&,             *%##               
        .&&&               &%&               
         #%%                  ,              
     ,/##/                                   
                                             ".Split("\n");
          currentRow = (int)(Console.WindowHeight*0.35);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currentRow);
            Console.Write(row);
            currentRow++;
          }
        }

        else if(fighter.name == "Genesis")
        {
            var rows = @"                                    */            
                                  ,,,..,/         
                                  ,@/,../@        
                                   .. ,*          
                               *,*../*/,,,.       
                                *..#/..*., @      
                                ,,(//*. .(.%      
                                ,.//,*,&,#,@      
                               #*.#((,,& (*#      
                               ,,**(/*,,&,/.      
                               ,*,*///,../#,    / 
                               /,.,/*.,.*,,.**    
                               (...*,**,.*,/      
                               ,**,,*  ,....@     
                          *//,**,.  ...  *...*@   
                    ///*,,      *.   /*.  *,%*/&@ 
                //*/            .,.   ,., .,,/%@@@
          ((/*/                  ,     ...*  ,,%&&
     #(/**                       ,.     ..    ,.  
 &**                           .*  .,   ., &      
                            ....        ,..%      
                                       ,....(     ".Split("\n");

            currentRow = (int)(Console.WindowHeight*0.3);
            foreach (string row in rows)
            {
                Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currentRow);
                Console.Write(row);
                currentRow++;
            }
        }

        else if(fighter.name == "Minos Prime")
        {
            var rows = @"          @%        
        (&&&        
        (&&&&*      
        &&&&#*      
        #(,,#,      
        ,#(##       
      .&#&#%%#@     
  *&@&%%%#(##%%%@@& 
  &&%/%#(((####%(&&.
  &&# /***/****((&&.
 @@&& #//###(/(&%&@.
 &&#@ (&%#%%#%& @%%&
 &@@  %#((((/(%% &@%
 @%@ ###(/##*(#% &@@
 #&@ ###(/*/(### *&&
   @ ##((/**/((#    
     ((((/ //((#    
      /((/ //(/#    
      #(//  /(#     
      %%#(  ##%     
      %&%% .%%&     
      .&%.  %&&     
      .@%.  %&&     
       %%   #&(     
      &@&   ,@@     ".Split("\n");

            currentRow = (int)(Console.WindowHeight*0.3);
            foreach (string row in rows)
            {
                Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currentRow);
                Console.Write(row);
                currentRow++;
        }
        }

        else if(fighter.name == "Amogus")
        {
            var rows = @"                                        
                 ,,.                    
          ,****************             
        **   .***************           
         ,(#%%*.     ********.          
     %@@@@@@@@@%%%%%%  ,******          
   %%%@@@@@@@@@&%%%%%(  ,*****          
   %%%%%%%%%%%%%%%%%**.  ****,   ****   
    ****/%%%%%#*******  *****,.  ****,  
         *********.    *****,,,  ,,,,,  
      **.         ,*********,,,  ,,,,,  
      *********************,,,,  ,,,,,  
      *******************,,,,,.  ,,,,,  
      ,,,,,********,,,,,,,,,,,   ,,,,,  
      ,,,,,,,,,,,,,,,,,,,,,,,,   ,,,,   
      ,,,,,,,,,,,,,,,,,,,,,,,,   ,,,.   
      ,,,,,,        ,,,,,,,,,,          
      .,,,,,,,       ,,,,,,,,,          
       ,,,,,,,       ,,,,,,,,,          
          ,,,         ,,,,,,,           
                                        ".Split("\n");
            currentRow = (int)(Console.LargestWindowHeight*0.3);
            foreach(string row in rows)
            {
                Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currentRow);
                Console.Write(row);
                currentRow++;
            }
        }

        else if(fighter.name == "Isshin, the Sword Saint")
        {
            var rows = @"                                         
                       /*               
                   ,/ ,/.               
                     /*%/,/             
                    *,*,...             
                     ***.               
                &#(((((,****            
               #///((//*,*/**           
             %/*,*,*(/,/.,*,.,          
            ,*,. ..(/,**..., ..         
           (**.   ,///...,..  ,         
          (...... *.,.,... .. ,.        
        (.,(.,.. ..*/**,....   *        
       ((....., ..//(//.. ..,  ,,       
     *,..,. ..  .#///*/    *, ,.,,      
  .        .. . (#(((/.    .....        
             ...(///(/.     ..          
               (/(///*      .,          
               (/*/*,*      *           
              *//((**   . ./.           
              /*//*//,,/  .*/           
             /((*,,/**(/, .,.           ".Split("\n");
            currentRow = (int)(Console.LargestWindowHeight*0.3);
            foreach(string row in rows)
            {
                Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currentRow);
                Console.Write(row);
                currentRow++;
            }
        }
    }
}