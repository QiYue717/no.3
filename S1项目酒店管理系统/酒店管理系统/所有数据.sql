use HotelSystems
go

select * from dbo.CashRegister
select * from dbo.client
select * from dbo.Employee
select * from dbo.EmployeeType
select * from dbo.food
select * from dbo.foodconsumption
select * from dbo.Foodtype
select * from dbo.History
select * from dbo.logging
select * from dbo.member
select * from dbo.money
select * from dbo.Room
select * from dbo.RoomState
select * from dbo.RoomType
select * from dbo.VIP



insert into CashRegister values (900,1,null,'Z101')

insert into client values ('小米','男','410232102123564103','166464546',1,'JD101',DEFAULT,null)
insert into foodconsumption values ('4','烤生蚝',70,40,'是','微辣的',4)

insert into History values ('木木','男','410232102123564102',null,11,DEFAULT,DEFAULT)

insert into logging values ('zs123','123456','Z001')
insert into logging values ('ls123','123456','Z002')
insert into logging values ('ww123','123456','Z003')
insert into logging values ('zl123','123456','Z004')
insert into logging values ('xq123','123456','Z005')
insert into logging values ('lb123','123456','Z006')

insert into member values (1,'黄金','123456789','女',36,'956864',1,256)


insert into money values (95,25,'Z004',29555959)

insert into Employee values ('张三','Z001',10000,'SSS')
insert into Employee values ('李四','Z002',5000,'S')
insert into Employee values ('王五','Z003',4000,'A')
insert into Employee values ('赵六','Z004',4000,'B')
insert into Employee values ('小七','Z005',4000,'C')
insert into Employee values ('老八','Z006',4000,'D')

insert into EmployeeType values ('副经理','S')
insert into EmployeeType values ('服务员','B')
insert into EmployeeType values ('保安','C')
insert into EmployeeType values ('保安','D')
insert into EmployeeType values ('收银员','A')
insert into EmployeeType values ('总经理','SSS')


insert into food values (1,'花菜',30,1)
insert into food values (2,'三鲜腐竹煲',30,1)
insert into food values (3,'西红柿炒蛋',30,1)
insert into food values (4,'茄子煲',30,1)
insert into food values (5,'夫妻肺片',30,1)
insert into food values (6,'豆角',30,1)
insert into food values (7,'家常豆腐',30,1)
insert into food values (8,'干锅娃娃菜',30,1)
insert into food values (9,'猪血丸子',30,1)
insert into food values (10,'鲫鱼',30,1)
insert into food values (11,'狗肉火锅',30,1)
insert into food values (12,'芹菜牛肉',30,1)
insert into food values (13,'胡萝卜炒肉',30,1)
insert into food values (14,'家常土豆粉',30,2)
insert into food values (15,'辣椒炒肉',30,2)
insert into food values (16,'芥末鸭子',30,2)
insert into food values (17,'阿拉斯加蟹',30,2)
insert into food values (18,'东坡肉',30,2)
insert into food values (19,'飘香辣子鸡',30,2)
insert into food values (20,'水煮鱼',30,2)
insert into food values (21,'鱼香茄子',30,2)
insert into food values (22,'风味鱿鱼',30,2)
insert into food values (23,'三鲜日本豆腐',30,2)
insert into food values (24,'菠萝古老肉',30,2)
insert into food values (25,'香辣鸡杂',30,2)
insert into food values (26,'酸辣牛肉',30,2)
insert into food values (27,'小炒牛肉',30,2)
insert into food values (28,'牛排',30,2)
insert into food values (29,'三文鱼刺身',30,3)
insert into food values (30,'刺身拼盘',30,3)
insert into food values (31,'烤生蚝',30,3)
insert into food values (32,'牛奶荔枝',30,3)
insert into food values (33,'哈密瓜捞',30,4)
insert into food values (34,'芒果捞',30,4)
insert into food values (35,'香辣肉丝拌饭',30,4)
insert into food values (36,'紫菜包饭',30,5)
insert into food values (37,'木须柿子拌饭',30,5)
insert into food values (38,'鸡蛋卷',30,5)
insert into food values (39,'石锅拌饭',30,5)
insert into food values (40,'蛋炒饭',30,5)



insert into Foodtype values ('干锅系列',1)
insert into Foodtype values ('精美小炒',2)
insert into Foodtype values ('西式套餐',3)
insert into Foodtype values ('水果沙拉',4)
insert into Foodtype values ('韩式系列',5)


insert into Room values('JD101',9900,'10086',4,'有洗衣机','1')

insert into Room values('JD102',498,'10086',1,'无线网络','1')
insert into Room values('JD103',9000,'10086',4,'空调房','1')
insert into Room values('JD104',386,'10086',2,'无线网络','1')
insert into Room values('JD105',469,'10086',3,'空调房','2')
insert into Room values('JD106',468,'10086',1,'电脑房','1')
insert into Room values('JD107',990,'10086',2,'无线网络','1')
insert into Room values('JD108',459,'10086',3,'空调房','1')
insert into Room values('JD109',486,'10086',1,'有洗衣机','1')
insert into Room values('JD201',484,'10086',2,'无线网络','1')
insert into Room values('JD202',435,'10086',3,'有洗衣机','1')
insert into Room values('JD203',9898,'10086',4,'有洗衣机','1')
insert into Room values('JD204',8989,'10086',4,'空调房','1')
insert into Room values('JD205',156,'10086',1,'无线网络','2')
insert into Room values('JD206',356,'10086',2,'有洗衣机','1')
insert into Room values('JD207',458,'10086',2,'有洗衣机','1')
insert into Room values('JD208',658,'10086',1,'空调房','1')
insert into Room values('JD209',589,'10086',3,'有洗衣机','1')
insert into Room values('JD301',256,'10086',1,'空调房','1')
insert into Room values('JD302',486,'10086',2,'有洗衣机','1')
insert into Room values('JD303',589,'10086',3,'空调房','1')
insert into Room values('JD304',568,'10086',2,'空调房','1')
insert into Room values('JD305',568,'10086',1,'有洗衣机','1')
insert into Room values('JD306',846,'10086',2,'电脑房','1')
insert into Room values('JD307',864,'10086',2,'有洗衣机','2')
insert into Room values('JD308',486,'10086',3,'无线网络','1')
insert into Room values('JD309',486,'10086',1,'电脑房','1')
insert into Room values('JD401',486,'10086',2,'有洗衣机','1')
insert into Room values('JD402',486,'10086',2,'电脑房','1')
insert into Room values('JD403',486,'10086',2,'无线网络','1')
insert into Room values('JD404',468,'10086',1,'空调房','1')
insert into Room values('JD405',486,'10086',3,'有洗衣机','2')
insert into Room values('JD406',486,'10086',3,'有洗衣机','1')
insert into Room values('JD407',486,'10086',3,'无线网络','1')
insert into Room values('JD408',486,'10086',1,'空调房','1')
insert into Room values('JD409',486,'10086',2,'有洗衣机','1')
insert into Room values('JD501',9850,'10086',4,'有洗衣机','2')
insert into Room values('JD502',786,'10086',3,'无线网络','1')
insert into Room values('JD504',486,'10086',2,'有洗衣机','1')
insert into Room values('JD505',486,'10086',2,'空调房','1')

insert into RoomState values('空房',1)
insert into RoomState values('有客',2)
insert into RoomState values('脏房',3)


insert into VIP values(1,'普通会员',0.7)
insert into VIP values(2,'银卡会员',0.6)
insert into VIP values(3,'金卡会员',0.5)

insert into RoomType values('普通双人间',1,108)

insert into RoomType values('普通单人间',2,99)
insert into RoomType values('豪华双人间',3,129)
insert into RoomType values('高档套房',4,500)
insert into RoomType values('豪华单人间',5,118)