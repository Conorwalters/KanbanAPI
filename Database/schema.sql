CREATE TABLE kanban_table
(
    id serial PRIMARY KEY not null,
    description varchar(125) not null
);

CREATE TABLE ticket
(
    Id int not null,
    description varchar(125) not null,
    label varchar(125) not null,
    type varchar(125) not null,
    status varchar(125) not null  
);

