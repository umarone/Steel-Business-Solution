using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Accounts.EL;
using System.Data.SqlClient;
using Accounts.Common;



namespace Accounts.DAL
{
    public class ProjectDAL
    {
        IDataReader objReader;
        public EntityoperationInfo Create(ProjectEL obj, SqlConnection objConn)
        {
            string sProcedure = "[Setup].[Proc_CreateProject]";
            EntityoperationInfo InsertInfo = new EntityoperationInfo();
            int EffectedRows = 0;

            using (SqlCommand cmdProject = new SqlCommand(sProcedure, objConn))
            {
                cmdProject.CommandType = CommandType.StoredProcedure;
                
                //cmdProject.Parameters.Add("@IdProject", SqlDbType.UniqueIdentifier).Value = obj.IdProject;
                cmdProject.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = obj.IdCompany;
                cmdProject.Parameters.Add("@ProjectCode", SqlDbType.VarChar).Value = obj.ProjectCode;
                cmdProject.Parameters.Add("@ProjectName", SqlDbType.VarChar).Value = obj.ProjectName;
                cmdProject.Parameters.Add("@City", SqlDbType.VarChar).Value = obj.City;
                cmdProject.Parameters.Add("@SiteAddress", SqlDbType.VarChar).Value = obj.SiteAddress;
                cmdProject.Parameters.Add("@IsHeadOffice", SqlDbType.Bit).Value = obj.HeadOffice;
                cmdProject.Parameters.Add("@IsStore", SqlDbType.Bit).Value = obj.Store;
                cmdProject.Parameters.Add("@Discription", SqlDbType.VarChar).Value = obj.Discription;
                cmdProject.Parameters.Add("@CreatedDateTime", SqlDbType.DateTime).Value = obj.CreatedDateTime;
                cmdProject.Parameters.Add("@ClosedDateTime", SqlDbType.DateTime).Value = obj.ClosedDate;
                cmdProject.Parameters.Add("@IsActive", SqlDbType.Bit).Value = obj.IsActive;

                EffectedRows = cmdProject.ExecuteNonQuery();
                if (EffectedRows > 0)
                {
                    InsertInfo.IsSuccess = true;
                }
                else
                {
                    InsertInfo.IsSuccess = false;
                }
            }
            return InsertInfo;
        }
        public EntityoperationInfo Update(ProjectEL obj, SqlConnection objConn)
        {
            string sProcedure = "[Setup].[Proc_UpdateProject]";
            EntityoperationInfo InsertInfo = new EntityoperationInfo();
            int EffectedRows = 0;

            using (SqlCommand cmdProject = new SqlCommand(sProcedure, objConn))
            {
                cmdProject.CommandType = CommandType.StoredProcedure;

                cmdProject.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = obj.IdProject;
                cmdProject.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = obj.IdCompany;
                cmdProject.Parameters.Add("@ProjectCode", SqlDbType.VarChar).Value = obj.ProjectCode;
                cmdProject.Parameters.Add("@ProjectName", SqlDbType.VarChar).Value = obj.ProjectName;
                cmdProject.Parameters.Add("@City", SqlDbType.VarChar).Value = obj.City;
                cmdProject.Parameters.Add("@SiteAddress", SqlDbType.VarChar).Value = obj.SiteAddress;
                cmdProject.Parameters.Add("@IsHeadOffice", SqlDbType.Bit).Value = obj.HeadOffice;
                cmdProject.Parameters.Add("@IsStore", SqlDbType.Bit).Value = obj.Store;
                cmdProject.Parameters.Add("@Discription", SqlDbType.VarChar).Value = obj.Discription;
                cmdProject.Parameters.Add("@CreatedDateTime", SqlDbType.DateTime).Value = obj.CreatedDateTime;
                cmdProject.Parameters.Add("@ClosedDateTime", SqlDbType.DateTime).Value = obj.ClosedDate;
                cmdProject.Parameters.Add("@IsActive", SqlDbType.Bit).Value = obj.IsActive;
                
                EffectedRows = cmdProject.ExecuteNonQuery();
                if (EffectedRows > 0)
                {
                    InsertInfo.IntID = obj.IdProject.Value;
                    InsertInfo.IsSuccess = true;
                }
                else
                {
                    InsertInfo.IsSuccess = false;
                }
            }
            return InsertInfo;
        }
        public EntityoperationInfo UpdateProjectAndCompanyName(ProjectEL obj, SqlConnection objConn)
        {
            string sProcedure = "[Setup].[Proc_UpdateProjectCompanyName]";
            EntityoperationInfo InsertInfo = new EntityoperationInfo();
            int EffectedRows = 0;

            using (SqlCommand cmdProject = new SqlCommand(sProcedure, objConn))
            {
                cmdProject.CommandType = CommandType.StoredProcedure;

                cmdProject.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = obj.CompanyName;
                cmdProject.Parameters.Add("@ProjectName", SqlDbType.VarChar).Value = obj.ProjectName;
               
                EffectedRows = cmdProject.ExecuteNonQuery();
                if (EffectedRows > 0)
                {
                    InsertInfo.IntID = obj.IdProject.Value;
                    InsertInfo.IsSuccess = true;
                }
                else
                {
                    InsertInfo.IsSuccess = false;
                }
            }
            return InsertInfo;
        }
        public EntityoperationInfo Delete(Int64? IdProject, SqlConnection objConn)
        {
            string sProcedure = "[Setup].[proc_DeleteProject]";
            EntityoperationInfo InsertInfo = new EntityoperationInfo();
            int EffectedRows = 0;

            using (SqlCommand cmdProject = new SqlCommand(sProcedure, objConn))
            {
                cmdProject.CommandType = CommandType.StoredProcedure;
                cmdProject.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;

                EffectedRows = cmdProject.ExecuteNonQuery();
                if (EffectedRows > 0)
                {
                    InsertInfo.IntID = IdProject.Value;
                    InsertInfo.IsSuccess = true;
                }
                else
                {
                    InsertInfo.IsSuccess = false;
                }
            }
            return InsertInfo;
        }
        public bool CheckProjectNameDuplication(Int64 IdCompany, string ProjectName, SqlConnection objConn)
        {
            List<ProjectEL> list = new List<ProjectEL>();
            SqlCommand cmdProjects = new SqlCommand("[Setup].[Proc_CheckProjectNameDuplication]", objConn);

            cmdProjects.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
            cmdProjects.Parameters.Add("@ProjectName", SqlDbType.VarChar).Value = ProjectName;

            cmdProjects.CommandType = CommandType.StoredProcedure;
            objReader = cmdProjects.ExecuteReader();
            while (objReader.Read())
            {
                ProjectEL oelCompany = new ProjectEL();

                ProjectEL obj = new ProjectEL();
                obj.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                obj.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                obj.ProjectCode = Validation.GetSafeLong(objReader["Project_Code"]);
                obj.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                //obj.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                obj.City = Validation.GetSafeString(objReader["City"]);
                obj.SiteAddress = Validation.GetSafeString(objReader["SiteAddress"]);
                obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                obj.HeadOffice = Validation.GetSafeBooleanNullable(objReader["HeadOffice"]);
                obj.Store = Validation.GetSafeBooleanNullable(objReader["Store"]);
                obj.IsActive = Convert.ToBoolean(objReader["IsActive"]);

                list.Add(oelCompany);
            }
            if (list.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<ProjectEL> ListByCompany(Int64 IdCompany, SqlConnection objConn)
        {
            string sProcedure = "[Setup].[Proc_GetAllProjectByCompany]";
            SqlCommand cmdProject = new SqlCommand(sProcedure, objConn);
            List<ProjectEL> list = new List<ProjectEL>();
            cmdProject.CommandType = CommandType.StoredProcedure;
            cmdProject.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
            objReader = cmdProject.ExecuteReader();
            while (objReader.Read())
            {

                ProjectEL obj = new ProjectEL();
                obj.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                obj.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                obj.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                obj.ProjectCode = Validation.GetSafeLong(objReader["Project_Code"]);
                obj.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                obj.City = Validation.GetSafeString(objReader["City"]);
                obj.SiteAddress = Validation.GetSafeString(objReader["SiteAddress"]);
                obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                obj.HeadOffice = Validation.GetSafeBooleanNullable(objReader["HeadOffice"]);
                obj.Store = Validation.GetSafeBooleanNullable(objReader["Store"]);
                obj.IsActive = Convert.ToBoolean(objReader["IsActive"]);

                list.Add(obj);
            }
            return list;
        }
        public List<ProjectEL> List(SqlConnection objConn)
        {
            string sProcedure = "[Setup].[Proc_GetAllProject]";
            SqlCommand cmdProject = new SqlCommand(sProcedure, objConn);
            List<ProjectEL> list = new List<ProjectEL>();
            objReader = cmdProject.ExecuteReader();
            while (objReader.Read())
            {

                ProjectEL obj = new ProjectEL();
                obj.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                obj.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                obj.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                obj.ProjectCode = Validation.GetSafeLong(objReader["Project_Code"]);
                obj.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                obj.City = Validation.GetSafeString(objReader["City"]);
                obj.SiteAddress = Validation.GetSafeString(objReader["SiteAddress"]);
                obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                obj.HeadOffice = Validation.GetSafeBooleanNullable(objReader["HeadOffice"]);
                obj.Store = Validation.GetSafeBooleanNullable(objReader["Store"]);
                obj.IsActive = Convert.ToBoolean(objReader["IsActive"]);

                list.Add(obj);
            }
            return list;
        }
        public List<ProjectEL> Select(Int64? IdProject, SqlConnection objConn)
        {
            if (IdProject == null)
                return null;
            else
            {
                string sProcedure = "[Setup].[proc_GetProject]";
                List<ProjectEL> List = new List<ProjectEL>();
                SqlCommand cmdProject = new SqlCommand(sProcedure, objConn);
                cmdProject.CommandType = CommandType.StoredProcedure;
                cmdProject.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;

                objReader = cmdProject.ExecuteReader();

                while (objReader.Read())
                {
                    ProjectEL obj = new ProjectEL();
                    obj.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                    obj.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                    obj.ProjectCode = Validation.GetSafeLong(objReader["Project_Code"]);
                    obj.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    obj.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                    obj.City = Validation.GetSafeString(objReader["City"]);
                    obj.SiteAddress = Validation.GetSafeString(objReader["SiteAddress"]);
                    obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                    obj.HeadOffice = Validation.GetSafeBooleanNullable(objReader["HeadOffice"]);
                    obj.Store = Validation.GetSafeBooleanNullable(objReader["Store"]);
                    obj.IsActive = Convert.ToBoolean(objReader["IsActive"]);

                    List.Add(obj);
                }
                return List;
            }
        }
    }
}
