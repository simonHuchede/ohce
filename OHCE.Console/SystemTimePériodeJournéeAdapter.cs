using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console
{
    internal class SystemTimePériodeJournéeAdapter
    {
        private PériodeJournée _périodeJournée;
        public PériodeJournée GetPériode(int date) 
        {
            
            if (date <= 12 && date > 6) 
            { 
                _périodeJournée = PériodeJournée.Matin; 
            } 
            if (date > 12 && date <= 18) 
            { 
                _périodeJournée = PériodeJournée.AprèsMidi; 
            } 
            if (date > 18 && date <= 22) 
            { 
                _périodeJournée = PériodeJournée.Soir; 
            } 
            else 
            { _périodeJournée = PériodeJournée.Nuit; }
            return _périodeJournée; 
        } 
    } 
}
    
