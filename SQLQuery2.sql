select*from flowers

insert into flowers (variety, colour, plu, farm_id, barcode, mix, sticker_text, lenght, bucket_size, sleeve_type, fob, price_pr_bunch, fairtrade, bunch_pr_box, bunch_pr_bucket, stems_pr_bunch, pake_rete)
values ('mirabel', 'red', '123123', '1', '121212333333', '0', 'mirabel' , '40', '15', 'sleeve 1', '2.1', '1.23', '1', '30','4', '15', '320') ;  

insert into flowers (variety, colour, plu, farm_id, barcode, mix, sticker_text, lenght, bucket_size, sleeve_type, fob, price_pr_bunch, fairtrade, bunch_pr_box, bunch_pr_bucket, stems_pr_bunch, pake_rete)
values ('Icebraker', 'red', '555555', '1', '121212333333', '0', 'icebraker' , '40', '12', 'sleeve 1', '2.1', '1.23', '1', '30','4', '15', '300') ;  

insert into flowers (variety, colour, plu, farm_id, barcode, mix, sticker_text, lenght, bucket_size, sleeve_type, fob, price_pr_bunch, fairtrade, bunch_pr_box, bunch_pr_bucket, stems_pr_bunch, pake_rete)
values ('Rhodos', 'red', '454545', '2', '121212333333', '0', 'rhodos' , '40', '12', 'sleeve 1', '2.1', '1.23', '1', '30','4', '15', '300') ;  

select*from farms
insert into farms (farm_id,farm_name, farm_code)
values ('1','Primarosa', '121212') ; 

insert into farms (farm_id,farm_name, farm_code)
values ('2','Penta', '332211') ;  

select flowers.variety, flowers.plu, farms.farm_name from flowers, farms where flowers.farm_id = farms.farm_id;