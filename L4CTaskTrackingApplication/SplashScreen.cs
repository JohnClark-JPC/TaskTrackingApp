using System;
using System.Collections.Generic;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class SplashScreen
    {
        public static void splashScreen()
        {
            //Font courtesy of patrojk.com
            Console.SetWindowSize(120, 60);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine(@"
                                                                                  
                                                                                  
                                                           ,;                                 
                                              .Gt        f#i                                  
                                             j#W:      .E#t    GEEEEEEEL                      
                                           ;K#f       i#W,     ,;;L#K;;.                      
                                         .G#D.       L#D.         t#E                         
                                        j#K;       :K#Wfff;       t#E                         
                                      ,K#f   ,GD;  i##WLLLLt      t#E                         
                                       j#Wi   E#t   .E#L          t#E                         
                                        .G#D: E#t     f#E:        t#E                         
                                          ,K#fK#t      ,WW;       t#E                         
                                            j###t       .D#;      t#E                         
                                             .G#t         tt       fE                         
                                               ;;                   :                         
                                                                                  
                                                               ,            ,             
                                                               Et           Et            
                                     .             :           E#t          E#t           
                                    ;W             Ef          E##t         E##t          
                                   f#E  GEEEEEEEL  E#t         E#W#t        E#W#t         
                                 .E#f   ,;;L#K;;.  E#t         E#tfL.       E#tfL.        
                                iWW;       t#E     E#t         E#t          E#t           
                               L##Lffi     t#E     E#t fi   ,ffW#Dffj.   ,ffW#Dffj.       
                              tLLG##L      t#E     E#t L#j   ;LW#ELLLf.   ;LW#ELLLf.      
                                ,W#i       t#E     E#t L#L     E#t          E#t           
                               j#E.        t#E     E#tf#E:     E#t          E#t           
                             .D#j          t#E     E###f       E#t          E#t           
                            ,WK,           t#E     E#K,        E#t          E#t           
                            EG.             fE     EL          E#t          E#t           
                            ,                :     :           ;#t          ;#t           
                                                                :;           :;           
                      ;                                                                   
                      ED.                :                                                
                      E#Wi              t#,      L.                      ,;               
                      E###G.           ;##W.     EW:        ,ft        f#i         ;f.    
                      E#fD#W;         :#L:WE     E##;       t#E      .E#t          i##:   
                      E#t t##L       .KG  ,#D    E###t      t#E     i#W,           i##:   
                      E#t  .E#K,     EE    ;#f   E#fE#f     t#E    L#D.            i##:   
                      E#t    j##f   f#.     t#i  E#t D#G    t#E  :K#Wfff;          i##:   
                      E#t    :E#K:  :#G     GK   E#t  f#E.  t#E  i##WLLLLt         i##:   
                      E#t   t##L     ;#L   LW.   E#t   t#K: t#E   .E#L             i##:   
                      E#t .D#W;       t#f f#:    E#t    ;#W,t#E     f#E:           i##:   
                      E#tiW#G.         f#D#;     E#t     :K#D#E      ,WW;          i#W.   
                      E#K##i            G#t      E#t      .E##E       .D#;         ,i.    
                      E##D.              t       ..         G#E         tt         :G#:   
                      E#t                                    fE                    iKt    
                      L:                                      ,                          ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(@"
        ///////////////////////////////////////////////////////////////////////////////////////////////
        //                                                                                           //
        //                                      © JPC Records                                        //
        //                       ---> Sweet dream, saccharine, loosen up <---                        //
        //                                                                                           //
        ///////////////////////////////////////////////////////////////////////////////////////////////
            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue. All I Want Is Everything");
            Console.ReadLine();
            Console.Clear();
            Program.MainMenu();
        }
    }
}
