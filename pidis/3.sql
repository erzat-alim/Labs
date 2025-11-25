create if not exists table districts(
id_district int primary key,
title text not null
)
create if not exists table contractors(
id_contractor int primary key,
name text not null
)
create if not exists table statuses(
id_status int primary key,
title text not null
)
create if not exists table routes(
id_route int primary key,
title text not null,
district_id int check(disctrict_id > 0),
contractor_id int check(contractor_id > 0),
rout_date date not null,
status_id int check(status_id > 0),

foreign key district_id references districts(id_district),
foreign key contractor_id references contractors(id_contractor),
foreign key status_id references status(id_status)
)
create if not exists table containers(
id_container int primary key,
title text not null
)
create if not exists table work_areas(
id_area int primary key,
address text not null,
container_id int check(container_id > 0),
district_id int check(disctrict_id > 0),
status_id int check(status_id > 0),

foreign key district_id references districts(id_district),
foreign key container_id references contractors(id_container),
foreign key status_id references status(id_status)
)
create if not exists table reports(
id_report int primary key,
report_date date not null,
areas_number int not null,
routes_number int not null,
workload int not null,
complains text not null,
expenses int not null,
completion_pct int not null
)

