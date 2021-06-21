using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SDS_LIB
{
    [DataContract]
    public class SDS_user_data
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string SecondName { get; set; }

        [DataMember]
        public string Patronymic { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Master { get; set; }

    }
    
    [DataContract]
    public class SDS_user_sport_data
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Height { get; set; }

        [DataMember]
        public string Weight { get; set; }

        [DataMember]
        public string ChestSTD { get; set; }

        [DataMember]
        public string ChestIN { get; set; }

        [DataMember]
        public string ChestOUT { get; set; }

        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public string Waist { get; set; }

        [DataMember]
        public string Hips { get; set; }

        [DataMember]
        public string Years { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string SpecialGroup { get; set; }
    }

    [DataContract]
    public class SDS_user_additional_data
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public string Stil_pulse { get; set; }

        [DataMember]
        public string Pulse_20squats { get; set; }

        [DataMember]
        public string Pulse_1min { get; set; }

        [DataMember]
        public string Pulse_2min { get; set; }

        [DataMember]
        public string Pulse_3min { get; set; }

        [DataMember]
        public string Step_pulse { get; set; }

        [DataMember]
        public string Step_pulse_2m { get; set; }

        [DataMember]
        public string Step_pulse_3m { get; set; }

        [DataMember]
        public string Stange { get; set; }

        [DataMember]
        public string Ghenci { get; set; }

        [DataMember]
        public string Kuper { get; set; }
    }

    [DataContract]
    public class SDS_user_normes
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public string Run_100m { get; set; }

        [DataMember]
        public string Cross { get; set; }

        [DataMember]
        public string Pull_up { get; set; }

        [DataMember]
        public string Push_ups { get; set; }

        [DataMember]
        public string Press { get; set; }

        [DataMember]
        public string Forward_bend { get; set; }

        [DataMember]
        public string Jump { get; set; }

        [DataMember]
        public string Swimming { get; set; }

        [DataMember]
        public string Ski { get; set; }

        [DataMember]
        public string Kettlebell { get; set; }
    }
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ISDS_service" в коде и файле конфигурации.
    [ServiceContract]
    public interface ISDS_service
    {
        [OperationContract]
        bool Registration(SDS_user_data user);

        [OperationContract]
        bool Login(string login, string password);

        [OperationContract]
        bool FindLogin(string login);

        [OperationContract]
        bool ChangeUserData(SDS_user_data data);

        [OperationContract]
        SDS_user_sport_data GetLastData(string login);

        [OperationContract]
        bool ChangeSportData(SDS_user_sport_data data);

        [OperationContract]
        List<SDS_user_sport_data> GetAllData(string login);

        [OperationContract]
        SDS_user_additional_data GetLastAdditionalData(string login);

        [OperationContract]
        bool ChangeAdditionalData(SDS_user_additional_data data);

        [OperationContract]
        List<SDS_user_additional_data> GetAllAdditionalData(string login);

        [OperationContract]
        SDS_user_normes GetLastNormes(string login);

        [OperationContract]
        bool ChangeNormesData(SDS_user_normes data);

        [OperationContract]
        List<SDS_user_normes> GetAllNormes(string login);

        [OperationContract]
        List<SDS_user_data> GetMasters(string login);

        [OperationContract]
        SDS_user_data GetMyData(string login);

        [OperationContract]
        SDS_user_data GetMyMaster(string login);
    }
}
