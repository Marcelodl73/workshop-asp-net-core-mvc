using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB já foi populado
            }

            Department d1 = new Department(1, "Computador");
            Department d2 = new Department(2, "Eletrônicos");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Livros");

            Seller s1 = new Seller(1, "Renata Leticia", "renata@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Aparecida", "maria@gmail.com", new DateTime(1979, 12, 31), 1500.0, d2);
            Seller s3 = new Seller(3, "Alex Dias", "alex@gmail.com", new DateTime(1988, 1, 15), 1000.0, d1);
            Seller s4 = new Seller(4, "Marta Fernanda", "marta@gmail.com", new DateTime(1993, 11, 30), 1000.0, d4);
            Seller s5 = new Seller(5, "Ronaldo Aparicio", "ronaldo@gmail.com", new DateTime(2000, 1, 9), 1000.0, d3);
            Seller s6 = new Seller(6, "Juliana Ferreira", "juliana@gmail.com", new DateTime(1997, 3, 4), 1000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 09), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 10), 7500.0, SaleStatus.Billed, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 11), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 12), 3300.0, SaleStatus.Billed, s1);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 16), 2000.0, SaleStatus.Billed, s2);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 17), 21000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 13), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 15), 15000.0, SaleStatus.Billed, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 21), 17000.0, SaleStatus.Billed, s2);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 20), 25500.0, SaleStatus.Billed, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 22), 19000.0, SaleStatus.Billed, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 23), 13000.0, SaleStatus.Billed, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 10, 07), 12900.0, SaleStatus.Billed, s3);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 10, 9), 18000.0, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 10), 15350.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 10, 11), 26999.0, SaleStatus.Billed, s4);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 10, 13), 12570.0, SaleStatus.Billed, s4);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 10, 14), 21000.0, SaleStatus.Billed, s4);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 10, 15), 22000.0, SaleStatus.Billed, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 17), 23000.0, SaleStatus.Billed, s5);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 24), 24000.0, SaleStatus.Billed, s5);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 19), 25000.0, SaleStatus.Billed, s5);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 12), 26280.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31), 27500.0, SaleStatus.Billed, s5);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 10, 6), 31000.0, SaleStatus.Billed, s6);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 10, 13), 32000.0, SaleStatus.Billed, s6);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 10, 7), 33000.0, SaleStatus.Billed, s6);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 10, 23), 34000.0, SaleStatus.Billed, s6);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 10, 12), 35000.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4);

            _context.SalesRecord.AddRange (
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
                );

            _context.SaveChanges();


        }

    }
}
