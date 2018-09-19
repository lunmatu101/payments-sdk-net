﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.Payments.Client.Model;
using System.Reflection;
using CM.Payments.Client.Enums;

//<auto-generated>
//	IMPORTANT NOTE:
//	This code is generated by MessageUnitTestGenerator in this project.
//	Date and time: 06-04-2018 14:52:28
//
//	Changes to this file may cause incorrect behavior and will be lost on the next code generation.
//</auto-generated>
namespace CM.Payments.Client.Test
{
	[TestClass, ExcludeFromCodeCoverage]
	public partial class QrRequestTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void QrRequest()
		{
			var obj = new QrRequest
			{
				Amount = 72,
				AmountChangeable = true,
				AmountMax = 16,
				AmountMin = 63,
				Beneficiary = "Lorum_871",
				CallbackUrl = "Lorum_19",
				CancelledUrl = "Lorum_572",
				Description = "Lorum_153",
				Expiration = "Lorum_678",
				ExpiredUrl = "Lorum_789",
				FailedUrl = "Lorum_668",
				OneOff = false,
				PurchaseId = "Lorum_833",
				Size = 45,
				SuccessUrl = "Lorum_379"
			};
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj.Amount, deserialized.Amount);
			Assert.AreEqual(obj.AmountChangeable, deserialized.AmountChangeable);
			Assert.AreEqual(obj.AmountMax, deserialized.AmountMax);
			Assert.AreEqual(obj.AmountMin, deserialized.AmountMin);
			Assert.AreEqual(obj.Beneficiary, deserialized.Beneficiary);
			Assert.AreEqual(obj.CallbackUrl, deserialized.CallbackUrl);
			Assert.AreEqual(obj.CancelledUrl, deserialized.CancelledUrl);
			Assert.AreEqual(obj.Description, deserialized.Description);
			Assert.AreEqual(obj.Expiration, deserialized.Expiration);
			Assert.AreEqual(obj.ExpiredUrl, deserialized.ExpiredUrl);
			Assert.AreEqual(obj.FailedUrl, deserialized.FailedUrl);
			Assert.AreEqual(obj.OneOff, deserialized.OneOff);
			Assert.AreEqual(obj.PurchaseId, deserialized.PurchaseId);
			Assert.AreEqual(obj.Size, deserialized.Size);
			Assert.AreEqual(obj.SuccessUrl, deserialized.SuccessUrl);
		}
	}
}