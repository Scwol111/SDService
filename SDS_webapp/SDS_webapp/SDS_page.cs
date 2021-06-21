using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SDS_LIB;

namespace SDS_webapp
{
    public class SDS_page: System.Web.UI.Page
    {
        protected SDS_serviceClient Client = null;
        protected string login;
        protected SDS_user_additional_data additional_Data = null;
        protected SDS_user_data data = null;
        protected SDS_user_normes user_Normes = null;
        protected SDS_user_sport_data user_Sport_Data = null;
        protected List<SDS_user_additional_data> additional_Data_list = null;
        protected List<SDS_user_normes> user_Normes_list = null;
        protected List<SDS_user_sport_data> user_Sport_Data_list = null;
        public SDS_serviceClient GetClient
        {
            get { return Client; }
        }
        public SDS_user_sport_data GetSportData
        {
            get { return user_Sport_Data; }
        }
        public SDS_user_normes GetNormes
        {
            get { return user_Normes; }
        }
        public SDS_user_data GetData
        {
            get { return data; }
        }
        public SDS_user_additional_data GetAdditionalData
        {
            get { return additional_Data; }
        }
        public string GetLogin
        {
            get { return "scwol"; }
        }
        public List<SDS_user_additional_data> GetAdditionalDataList
        {
            get { return additional_Data_list; }
        }
        public List<SDS_user_normes> GetNormesList
        {
            get { return user_Normes_list; }
        }
        public List<SDS_user_sport_data> GetSportDataList
        {
            get { return user_Sport_Data_list; }
        }
    }
}