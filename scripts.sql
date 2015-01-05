/* Tables */

CREATE TABLE IF NOT EXISTS "incident" (
  "id" serial NOT NULL,
  "incident_number" varchar(40),
  "severity" char(1),
  "assignee" varchar(40),
  "assignment_id" int,
  "status" varchar(40),
  "open_time" timestamp,
  "update_time" timestamp,
  "resolve_time" timestamp,
  "close_time" timestamp,
  "reopen_time" timestamp,
  "sla_breached" boolean,
  "vendor_ticket" varchar(40)
);

CREATE TABLE IF NOT EXISTS "assignment" (
  "id" serial NOT NULL,
  "name" varchar(255),
  "description" varchar(2000)
);

/* Primary Key */

ALTER TABLE "incident" ADD CONSTRAINT inc_id_pk ("id");  
ALTER TABLE "assignment" ADD CONSTRAINT assign_id_pk ("id");

/* Foreign Key */

ALTER TABLE "incident" ADD CONSTRAINT inc_assign_id_fk FOREIGN KEY ("assignement_id") REFERENCES "assignment" ("id");
