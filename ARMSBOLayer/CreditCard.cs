using System;
using System.Collections.Generic;
using System.IO;
using ARMSDALayer ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSBOLayer
{
    public class CreditCard
    {
        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private string m_MerchantName;
        private DateTime m_ExpDate;
        private string m_AddressLine1;

        private string m_AddressLine2;
        private string m_City;
        private string m_StateCode;
        private string m_ZipCode;
        private string m_Country;
        private decimal m_CreditCardLimit;
        private decimal m_CreditCardBalance;
        private bool m_ActivationStatus = true;
        public CreditCard()
        {
            m_CreditCardNumber = "";
            m_CreditCardOwnerName = "";
            m_MerchantName = "";
            m_ExpDate = new DateTime().Date;
            m_AddressLine1 = "";
            m_AddressLine2 = "";
            m_City = "";
            m_StateCode = "";
            m_ZipCode = "";
            m_Country = "";
            m_CreditCardLimit = 3000;
            m_CreditCardBalance = 3000;
            m_ActivationStatus = true;
        }

        public bool Activate()
        {
            m_ActivationStatus = true;
            return m_ActivationStatus;
        }
        public bool Deactivate()
        {
            m_ActivationStatus = false;
            return m_ActivationStatus;
        }
        protected bool DALayer_Insert()
        {
   
            try
            {
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                CreditCardDTO objCreditCardDTO = new CreditCardDTO();

                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.MerchantName = this.MerchantName;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;

                bool inserted = objCreditCardDAO.Insert(objCreditCardDTO);

                if (inserted == true)
                {
 
                    return true;
                }
                else
                {

                    return false;
                }
            }

            catch (Exception objE)
            {

                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);
            }
        }
        protected bool DALayer_Load(string key)
        {
            try
            {

                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();
    
                CreditCardDTO objCreditCardDTO = objCreditCardDAO.GetRecordByID(key);
     
                if (objCreditCardDTO != null)
                {
                    this.CreditCardNumber = objCreditCardDTO.CreditCardNumber;
                    this.CreditCardOwnerName = objCreditCardDTO.CreditCardOwnerName;
                    this.MerchantName = objCreditCardDTO.MerchantName;
                    this.ExpDate = objCreditCardDTO.ExpDate;
                    this.AddressLine1 = objCreditCardDTO.AddressLine1;
                    this.AddressLine2 = objCreditCardDTO.AddressLine2;
                    this.City = objCreditCardDTO.City;
                    this.StateCode = objCreditCardDTO.StateCode;
                    this.ZipCode = objCreditCardDTO.ZipCode;
                    this.Country = objCreditCardDTO.Country;
                    this.CreditCardLimit = objCreditCardDTO.CreditCardLimit;
                    this.CreditCardBalance = objCreditCardDTO.CreditCardBalance;

                    if (objCreditCardDTO.ActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }
        protected bool DALayer_Delete(string key)
        {

            try
            {
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                bool deleted = objCreditCardDAO.Delete(key);

                if (deleted == true)
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }

            catch (Exception objE)
            {

                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }
        protected bool DALayer_Update()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();
                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();
                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.MerchantName = this.MerchantName;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;
                bool updated = objCreditCardDAO.Update(objCreditCardDTO);

                if (updated == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception objE)
            {

                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }
        protected static List<CreditCard> DALayer_GetAllCreditCards()
        {

            try
            {

                DALObjectFactoryBase objDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                List<CreditCardDTO> objCreditCardDTOList = objCreditCardDAO.GetAllRecords();

                if (objCreditCardDTOList != null)
                {

                    List<CreditCard> objCreditCardList = new List<CreditCard>();
 
                    foreach (CreditCardDTO objDTO in objCreditCardDTOList)
                    {

                        CreditCard objCreditCard = new CreditCard();

                        objCreditCard.CreditCardNumber = objDTO.CreditCardNumber;
                        objCreditCard.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                        objCreditCard.MerchantName = objDTO.MerchantName;
                        objCreditCard.ExpDate = objDTO.ExpDate;
                        objCreditCard.AddressLine1 = objDTO.AddressLine1;
                        objCreditCard.AddressLine2 = objDTO.AddressLine2;
                        objCreditCard.City = objDTO.City;
                        objCreditCard.StateCode = objDTO.StateCode;
                        objCreditCard.ZipCode = objDTO.ZipCode;
                        objCreditCard.Country = objDTO.Country;
                        objCreditCard.CreditCardLimit = objDTO.CreditCardLimit;
                        objCreditCard.CreditCardBalance = objDTO.CreditCardBalance;

                        if (objDTO.ActivationStatus == true)
                            objCreditCard.Activate();
                        else
                            objCreditCard.Deactivate();

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
        }//End of method

        public static List<CreditCard> GetAllCreditCards()
        {
            return DALayer_GetAllCreditCards();
        }
        public Boolean Load(string key)
        {
            return DALayer_Load(key);
        }
        public Boolean Insert()
        {
            return DALayer_Insert();
        }
        public Boolean Delete(string key)
        {
            return DALayer_Delete(key);
        }
        public Boolean Update()
        {
            return DALayer_Update();
        }
        public CreditCard(string CreditCardNumberPAR, string CardOwnerPAR, string MerchNamePar, string EXPDatePAR, string AddressLine1PAR,
            string AddressLine2PAR, string CityPar, string StateCodePAR, string ZipCodePAR, string CountryPAR, decimal CreditCardLimitPAR,decimal CreditCardBalance)
        {
            m_ExpDate = Convert.ToDateTime(EXPDatePAR);
            m_CreditCardNumber = CreditCardNumberPAR;
            m_CreditCardOwnerName = CardOwnerPAR;
            m_MerchantName = MerchNamePar;
            m_AddressLine1 = AddressLine1PAR;
            m_AddressLine2 = AddressLine2PAR;
            m_City = CityPar;
            m_StateCode = StateCodePAR;
            m_ZipCode = ZipCodePAR;
            m_Country = CountryPAR;
            m_CreditCardLimit = CreditCardLimitPAR;
            m_CreditCardBalance = CreditCardBalance;
            m_ActivationStatus = true;
        }
        public string CreditCardNumber
        {
            get
            {
                return this.m_CreditCardNumber;
            }
            set
            {
                this.m_CreditCardNumber = value;
            }
        }
        public string CreditCardCompany
        {
            get
            {
                return this.m_MerchantName;
            }
            set
            {
                this.m_MerchantName = value;
            }
        }
        public string CreditCardOwnerName
        {
            get
            {
                return this.m_CreditCardOwnerName;
            }
            set
            {
                this.m_CreditCardOwnerName = value;
            }
        }
        public string MerchantName
        {
            get
            {
                return this.m_MerchantName;
            }
            set
            {
                this.m_MerchantName = value;
            }
        }
        public DateTime ExpDate
        {
            get
            {
                return this.m_ExpDate;
            }
            set
            {
                this.m_ExpDate = value;
            }
        }
        public string AddressLine1
        {
            get
            {
                return this.m_AddressLine1;
            }
            set
            {
                this.m_AddressLine1 = value;
            }
        }
        public string AddressLine2
        {
            get
            {
                return this.m_AddressLine2;
            }
            set
            {
                this.m_AddressLine2 = value;
            }

        }
        public string City
        {
            get
            {
                return this.m_City;
            }
            set
            {
                this.m_City = value;
            }
        }
        public string StateCode
        {
            get
            {
                return this.m_StateCode;
            }
            set
            {
                this.m_StateCode = value;
            }
        }
        public string ZipCode
        {
            get
            {
                return this.m_ZipCode;
            }
            set
            {
                this.m_ZipCode = value;
            }
        }
        public string Country
        {
            get
            {
                return this.m_Country;
            }
            set
            {
                this.m_Country = value;
            }
        }
        public decimal CreditCardLimit
        {
            get
            {
                return this.m_CreditCardLimit;
            }
            set
            {
                this.m_CreditCardLimit = value;
            }
        }
        public decimal CreditCardBalance
        {
            get
            {
                return this.m_CreditCardBalance;
            }
            set
            {
                this.m_CreditCardBalance = value;
            }
        }

        public bool ActivationStatus
        {
            get
            {
                return this.m_ActivationStatus;
            }
            set
            {
                this.m_ActivationStatus = value;
            }
        }
        ~CreditCard()
        {
        }
    }
}
