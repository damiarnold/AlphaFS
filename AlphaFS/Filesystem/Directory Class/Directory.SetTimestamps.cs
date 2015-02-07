/*  Copyright (C) 2008-2015 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using System;
using System.Security;

namespace Alphaleonis.Win32.Filesystem
{
   partial class Directory
   {
      /// <summary>[AlphaFS] Sets all the date and time stamps for the specified directory, at once.</summary>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Sets all the date and time stamps for the specified directory, at once.</summary>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), pathFormat);
      }



      /// <summary>[AlphaFS] Sets all the date and time stamps, in coordinated universal time (UTC), for the specified directory, at once.</summary>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Sets all the date and time stamps, in coordinated universal time (UTC), for the specified directory, at once.</summary>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, pathFormat);
      }

      #region Transactional

      /// <summary>[AlphaFS] Sets all the date and time stamps for the specified directory, at once.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetTimestamps(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Sets all the date and time stamps for the specified directory, at once.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetTimestamps(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), pathFormat);
      }



      /// <summary>[AlphaFS] Sets all the date and time stamps, in coordinated universal time (UTC), for the specified directory, at once.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetTimestampsUtc(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Sets all the date and time stamps, in coordinated universal time (UTC), for the specified directory, at once.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetTimestampsUtc(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, pathFormat);
      }

      #endregion // Transactional
   }
}