using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchProjectAssignment.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string ReservationCode { get; set; }
        public string ExternalCode { get; set; }
        public string ReservationStatus { get; set; }
        public string MemberName { get; set; }
        public string VehicalId { get; set; }
        public string Category { get; set; }
        public string VehicalInfo { get; set; }
        public string OwnerName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string PickupLocation { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> Balance { get; set; }


        public List<Reservation> GetData()
        {
            List<Reservation> listReservation = new List<Reservation>();
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Pritam Los Angels Airport",
                StartDate = Convert.ToDateTime("27-Jul-2017"),
                StartTime = Convert.ToDateTime("27-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Inomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("27-Jul-2017"),
                StartTime = Convert.ToDateTime("27-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Inomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("27-Jul-2017"),
                StartTime = Convert.ToDateTime("27-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("27-Jul-2017"),
                StartTime = Convert.ToDateTime("27-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Cancel",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("27-Jul-2017"),
                StartTime = Convert.ToDateTime("27-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("27-Jul-2017"),
                StartTime = Convert.ToDateTime("27-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("27-Jul-2017"),
                StartTime = Convert.ToDateTime("27-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("27-Jul-2017"),
                StartTime = Convert.ToDateTime("01-Aug-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("01-Aug-2017"),
                StartTime = Convert.ToDateTime("01-Aug-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("01-Aug-2017"),
                StartTime = Convert.ToDateTime("01-Aug-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("01-Aug-2017"),
                StartTime = Convert.ToDateTime("01-Aug-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("01-Aug-2017"),
                StartTime = Convert.ToDateTime("01-Aug-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-May-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("01-Aug-2017"),
                StartTime = Convert.ToDateTime("01-Aug-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("01-Aug-2017"),
                StartTime = Convert.ToDateTime("01-Aug-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("01-Aug-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("23-Jun-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Incomplete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            listReservation.Add(new Reservation
            {
                DateCreated = Convert.ToDateTime("27-Jan-2017"),
                ReservationCode = "XDRSF542",
                ExternalCode = "SSDDFR55W",
                ReservationStatus = "Complete",
                MemberName = "Fox User",
                VehicalId = "ASD4",
                Category = "ECAR",
                VehicalInfo = "--,--,--",
                OwnerName = "Los Angels Airport",
                StartDate = Convert.ToDateTime("25-Jul-2017"),
                StartTime = Convert.ToDateTime("25-Jul-2017  10:11:00 AM"),
                EndDate = Convert.ToDateTime("26-Jul-2017"),
                EndTime = Convert.ToDateTime("26-Jul-2017  05:11:00 PM"),
                PickupLocation = "Los Angels Airport/LAX",
                TotalAmount = 87,
                Balance = 0
            });
            return listReservation;
        }
    }
}