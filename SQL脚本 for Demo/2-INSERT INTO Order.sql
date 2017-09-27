USE [TripOrderDB]
GO

INSERT INTO [dbo].[Order]
           ([OrderStateID],
	        [Amount],
	        [ProductID],
	        [ProductName],
	        [MemberID],
	        [MemberName],
	        [OrderCreatedTime]
		   )
     VALUES
           (0
           ,1600
           ,1
           ,'中国上海二天一夜游'
           ,1
           ,'杨先生'
           ,GETDATE()            
		   )
GO

INSERT INTO [dbo].[Order]
           ([OrderStateID],
	        [Amount],
	        [ProductID],
	        [ProductName],
	        [MemberID],
	        [MemberName],
	        [OrderCreatedTime]
		   )
     VALUES
           (1
           ,1100
           ,2
           ,'中国桂林三天二夜游'
           ,2
           ,'王女士'
           ,GETDATE()            
		   )
GO

INSERT INTO [dbo].[Order]
           ([OrderStateID],
	        [Amount],
	        [ProductID],
	        [ProductName],
	        [MemberID],
	        [MemberName],
	        [OrderCreatedTime]
		   )
     VALUES
           (2
           ,9999
           ,3
           ,'中国杭州一日游'
           ,3
           ,'万先生'
           ,GETDATE()            
		   )
GO


