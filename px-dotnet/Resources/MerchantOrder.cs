﻿using MercadoPago.DataStructures.MerchantOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MercadoPago.Resources
{
    public class MerchantOrder : MPBase
    {
        #region Actions
        
        public MerchantOrder Load(string id) 
        {
            return Load(id, WITHOUT_CACHE);
        }

        [GETEndpoint("/merchant_order/:id")]
        public MerchantOrder Load(string id, bool useCache)
        {
            return (MerchantOrder)ProcessMethod<MerchantOrder>(typeof(MerchantOrder), "Load", id, useCache);
        }
        
        [POSTEndpoint("/merchant_order")]
        public MerchantOrder Save() 
        {
            return (MerchantOrder)ProcessMethod<MerchantOrder>("Save", WITHOUT_CACHE);
        }
        
        [PUTEndpoint("/merchant_order/:id")]
        public MerchantOrder Update() 
        {
            return (MerchantOrder)ProcessMethod<MerchantOrder>("Update", WITHOUT_CACHE);
        }

        #endregion

        #region Properties

        private string id;
        private string preferenceId;
        private DateTime? dateCreated;
        private DateTime? lastUpdate;
        private string applicationId;
        private string status;
        private string siteId;
        private Payer payer;
        private Collector collector;
        private long? sponsorId;
        private List<MerchantOrderPayment> payments;
        private float? paidAmount;
        private float? refundedAmount;
        private float? shippingCost;
        private bool? cancelled;
        private List<Item> items;
        private List<Shipment> shipments;
        [StringLength(500)]
        private string notificationUrl;
        [StringLength(600)]
        private string additionalInfo;
        [StringLength(256)]
        private string externalReference;
        [StringLength(256)]
        private string marketplace;
        private float? totalAmount;

        #endregion

        #region Accessors
       
        public string ID
        {
            get { return id; }
            set { this.id = value; } //This Accessor must be removed after testing approvement.
        }
       
        public string PreferenceId
        {
            get { return preferenceId; }
            set { preferenceId = value; }
        }        

        public DateTime? DateCreated
        {
            get { return dateCreated; }            
        }

        

        public DateTime? LastUpdate
        {
            get { return lastUpdate; }            
        }

        public string ApplicationId
        {
            get { return applicationId; }
            set { applicationId = value; }
        }

        public string Status
        {
            get { return status; }            
        }

        public string SiteId
        {
            get { return siteId; }
            set { siteId = value; }
        }

        public Payer Payer
        {
            get { return payer; }
            set { payer = value; }
        }

        public Collector Collector
        {
            get { return collector; }
            set { collector = value; }
        }

        public long? SponsorId
        {
            get { return sponsorId; }
            set { sponsorId = value; }
        }

        public List<MerchantOrderPayment> Payments
        {
            get { return payments; }            
        }        

        public float? PaidAmount
        {
            get { return paidAmount; }            
        }
       
        public float? RefundedAmount
        {
            get { return refundedAmount; }            
        }

        public float? ShippingCost
        {
            get { return shippingCost; }            
        }

        public bool? Cancelled
        {
            get { return cancelled; }
            set { cancelled = value; }
        }

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        public void AppendItem(Item item)
        {
            if (items == null)
            {
                items = new List<Item>();
            }
            items.Add(item);            
        }        

        public List<Shipment> Shipments
        {
            get { return shipments; }
            set { shipments = value; }
        }

        public void AppendShipment(Shipment shipment)
        {
            if (shipments == null)
            {
                shipments = new List<Shipment>();
            }
            shipments.Add(shipment);            
        }

        public string NotificationUrl
        {
            get { return notificationUrl; }
            set { notificationUrl = value; }
        }

        public string AdditionalInfo
        {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }

        public string ExternalReference
        {
            get { return externalReference; }
            set { externalReference = value; }
        }

        public string Marketplace
        {
            get { return marketplace; }
            set { marketplace = value; }
        }
       
        public float? TotalAmount
        {
            get { return totalAmount; }
        }

        #endregion
    }
}
