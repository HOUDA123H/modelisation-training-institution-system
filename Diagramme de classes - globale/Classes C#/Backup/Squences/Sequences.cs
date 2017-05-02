// File:    Sequences.cs
// Author:  ESSARRAJ
// Created: dimanche 28 d�cembre 2014 17:00:13
// Purpose: Definition of Class Sequences

using System;

namespace Squences
{
   public class Sequences
   {
      private int id;
      private String titre;
      private String objectif;
      private String competencesVises;
      private String competencesTransversales;
      
      public Modules.Precision[] precision;
      
      /// <summary>
      /// Property for collection of Modules.Precision
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public Precision[] Precision
      {
         get
         {
            return precision;
         }
         set
         {
            precision = value;
         }
      }
   
   }
}