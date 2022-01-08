using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ARMSDALayer;

namespace ARMSBOLayer
{
    public class USState
    {
        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public USState()
        {
            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";
        }
        public USState(int StateIDPar, string StateCodePar, string StateNamePar)
        {
            this.StateID = StateIDPar;
            this.StateCode = StateCodePar;
            this.StateName = StateNamePar;



        }
        public void Print()
        {
            try {
                USState ObjValue = new USState();
                const string Path = "Network_Printer.txt";
                StreamWriter obj1 = new StreamWriter(File.Create(Path));
                obj1.Write(ObjValue.StateID);
                obj1.Write(ObjValue.StateCode);
                obj1.Write(ObjValue.StateName);
            }


            catch (Exception objE)
            {

                throw new Exception("Unexpected Error"+
                objE.Message);
            }
        }

        public static List<USState> GetAllUSStates()
        {
            return DALayer_GetAllUSStates();
        }
        public static List<USState> DALayer_GetAllUSStates()
        {
            try
            {

                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                USStateDAO objUSStateDAO = objDAOFactory.GetUSStateDAO();

                List<USStateDTO> objUSStateDTOList = objUSStateDAO.GetAllRecords();

                if (objUSStateDTOList != null)
                {

                    List<USState> objUSStateList = new List<USState>();

                    foreach (USStateDTO objDTO in objUSStateDTOList)
                    {

                        USState objUSState = new USState();

                        objUSState.StateCode = objDTO.StateCode;
                        objUSState.StateID = objDTO.StateID;
                        objUSState.StateName = objDTO.StateName;

                        objUSStateList.Add(objUSState);
                    }

                    return objUSStateList;
                }
                else
                {

                    return null;
                }
            }

            catch (Exception objE)
            {

                throw new Exception("Unexpected Error in DALayer_GetAllUSStates() Method: {0} " +
                objE.Message);
            }
        }
        ~USState()
        {

        }
    }
}
