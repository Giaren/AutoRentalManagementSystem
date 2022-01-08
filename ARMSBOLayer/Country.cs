using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;

namespace ARMSBOLayer
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        public string CountryName { get; set; }

        public Country()
        {
            this.CountryID = 0;
            this.CountryCode2 = "";
            this.CountryCode3 = "";
            this.CountryName = "";
        }
        public Country(int CountryIDPar, string CountryCode2PAR, string CountryCode3PAR, string CountryName)
        {
            this.CountryID = CountryIDPar;
            this.CountryCode2 = CountryCode2PAR;
            this.CountryCode3 = CountryCode3PAR;
            this.CountryName = CountryName;



        }
        public void Print()
        {
            try
            {
                Country ObjValue = new Country();
                const string Path = "Network_Printer.txt";
                StreamWriter obj1 = new StreamWriter(File.Create(Path));
                obj1.Write(ObjValue.CountryID);
                obj1.Write(ObjValue.CountryCode2);
                obj1.Write(ObjValue.CountryCode3);
                obj1.Write(ObjValue.CountryName);
            }
            catch (Exception objE)
            {

                throw new Exception("Unexpected Error" +
                objE.Message);
            }
        }

        public static List<Country> DALayerGetAllCountries()
        {
            try
            {

                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CountryDAO objCreditCardDAO = objDAOFactory.GetCountryDAO();

                List<CountryDTO> objCreditCardDTOList = objCreditCardDAO.GetAllRecords();

                if (objCreditCardDTOList != null)
                {

                    List<Country> objCreditCardList = new List<Country>();

                    foreach (CountryDTO objDTO in objCreditCardDTOList)
                    {

                        Country objCreditCard = new Country();

                        objCreditCard.CountryID = objDTO.CountryID;
                        objCreditCard.CountryCode2 = objDTO.CountryCode2;
                        objCreditCard.CountryCode3 = objDTO.CountryCode3;
                        objCreditCard.CountryName = objDTO.CountryName;
       

                        objCreditCardList.Add(objCreditCard);
                    }

                    return objCreditCardList;
                }
                else
                {

                    return null;
                }
            }

            catch (Exception objE)
            {

                throw new Exception("Unexpected Error in DALayer_GetAllCreditCards(key) Method: {0} " +
                objE.Message);
            }

        }
        public static List<Country> GetAllCountries()
        {
            return DALayerGetAllCountries();

        }

            ~Country()
        {

        }
    }
}
