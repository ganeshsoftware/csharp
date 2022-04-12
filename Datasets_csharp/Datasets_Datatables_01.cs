using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

/*
	Possible types based on which i can create a DataColumn
	--------------------------------------------------------------------------------------
	Boolean , Decimal, Int16, Int32, Int64, UInt16, UInt32, UInt64, Datetime, Char, String
	--------------------------------------------------------------------------------------
*/

namespace Ganesh.DataSetsDemo
{
	class DataSetCreation
	{
		public static void Main()
		{
			/*
				1. Creating the DataTables.  
			
			*/
			
			// Create DataSet Hospital 
			DataSet hospital = new DataSet("Hospital");

			// Create DataTable Doctor
			DataTable doctors = new DataTable("Doctor");
			doctors.Columns.Add(new DataColumn("Iden", typeof(System.Int32)));
			doctors.Columns.Add(new DataColumn("Caption", typeof(System.String)));
			doctors.Columns.Add(new DataColumn("Name", typeof(System.String)));
			doctors.Columns.Add(new DataColumn("DateOfJoin", typeof(System.DateTime)));
			doctors.Columns.Add(new DataColumn("BloodGroup", typeof(System.String)));
			doctors.Columns.Add(new DataColumn("Gender", typeof(System.String)));
			doctors.Columns.Add(new DataColumn("Photo", typeof(System.String)));
			doctors.Columns.Add(new DataColumn("Department", typeof(System.Int32)));
			doctors.Columns.Add(new DataColumn("Speciality", typeof(System.Int32)));
			
			// Add DataTable Doctor to DataSet hospital.
			hospital.Tables.Add(doctors);

			
			
			// Create DataTable Patient 
			DataTable patients = new DataTable("Patient");
			patients.Columns.Add(new DataColumn("Iden",typeof(System.Int32)));
			patients.Columns.Add(new DataColumn("LastName",typeof(System.String)));
			patients.Columns.Add(new DataColumn("Gender",typeof(System.String)));
			patients.Columns.Add(new DataColumn("DOB",typeof(System.DateTime)));
			patients.Columns.Add(new DataColumn("BloodGroup",typeof(System.String)));
			patients.Columns.Add(new DataColumn("Address",typeof(System.String)));
			patients.Columns.Add(new DataColumn("Photo",typeof(System.String)));
			patients.Columns.Add(new DataColumn("EMailID",typeof(System.String)));
			patients.Columns.Add(new DataColumn("MobileNumber",typeof(System.String)));
			
			// Add DataTable Patient to DataSet hospital.
			hospital.Tables.Add(patients);
			


			// Create DataTable Appointment
			DataTable appointments = new DataTable("Appointment");
			appointments.Columns.Add(new DataColumn("AppointmentId",typeof(System.Int32)));
			appointments.Columns.Add(new DataColumn("Patient",typeof(System.Int32)));
			appointments.Columns.Add(new DataColumn("Doctor",typeof(System.Int32)));
			appointments.Columns.Add(new DataColumn("AppointmentDate",typeof(System.DateTime)));
			appointments.Columns.Add(new DataColumn("AppointmentStartTime",typeof(System.String)));
			appointments.Columns.Add(new DataColumn("AppointmentEndTime",typeof(System.String)));
			
			// Add DataTable appointments to DataSet hospital.
			hospital.Tables.Add(appointments);
			
			
			/* 
				2. Setting up relationships in the DataTables.
			*/
			
			// Primary key setting for Doctor.
			DataColumn[] pk_Doctor = new DataColumn[1];
			pk_Doctor[0] = hospital.Tables["Doctor"].Columns["Iden"];
			hospital.Tables["Doctor"].PrimaryKey = pk_Doctor;
		
			// Primary key setting for Patient.
			DataColumn[] pk_Patient = new DataColumn[1];
			pk_Patient[0] = hospital.Tables["Patient"].Columns["Iden"];
			hospital.Tables["Doctor"].PrimaryKey = pk_Patient;

			
			// Primary and Foreign Key setting for Patient.
			DataColumn[] pk_Appointment = new DataColumn[1];
			pk_Appointment[0] = hospital.Tables["Appointment"].Columns["AppointmentId"];
			hospital.Tables["Doctor"].PrimaryKey = pk_Appointment;
			
			
			
			// 1. Doctor_Appointment => Doctor.Iden serving as a FK to Appointment.Doctor
			hospital.Relations.Add("Doctor_Appointment",hospital.Tables["Doctor"].Columns["Iden"], hospital.Tables["Appointment"].Columns["Doctor"]);
			
			// Key serving as the reference key
			DataColumn parentDoctor = hospital.Tables["Doctor"].Columns["Iden"];

			// Key serving as the reference key
			DataColumn parentPatient = hospital.Tables["Patient"].Columns["Iden"];


			
		}
	}
}