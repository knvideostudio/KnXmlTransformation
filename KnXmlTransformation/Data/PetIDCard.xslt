<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" indent="yes" encoding="iso-8859-1" />

  <xsl:template match="card">

    <!-- Practice information -->
    <PracticeInfo>
      <xsl:variable name="vPracticeId" select="clinic/id" />
      <xsl:attribute name="id">
        <xsl:value-of select="clinic/id" />
      </xsl:attribute>
      <xsl:attribute name="name">
        <xsl:value-of select="clinic/name"/>
      </xsl:attribute>
      <xsl:attribute name="address1">
        <xsl:value-of select="clinic/address1"/>
      </xsl:attribute>
      <xsl:attribute name="address2">
        <xsl:value-of select="clinic/address2"/>
      </xsl:attribute>
      <xsl:attribute name="city">
        <xsl:value-of select="clinic/city"/>
      </xsl:attribute>
      <xsl:attribute name="state">
        <xsl:value-of select="clinic/state"/>
      </xsl:attribute>
      <xsl:attribute name="zip">
        <xsl:value-of select="clinic/zip"/>
      </xsl:attribute>
      <xsl:attribute name="phone">
        <xsl:value-of select="clinic/phone"/>
      </xsl:attribute>
      <xsl:attribute name="url">
        <xsl:value-of select="clinic/url"/>
      </xsl:attribute>
      <xsl:attribute name="email">
        <xsl:value-of select="clinic/email"/>
      </xsl:attribute>
      <xsl:attribute name="country">
        <xsl:value-of select="clinic/country"/>
      </xsl:attribute>
      <xsl:attribute name="logo">
        <xsl:value-of select="clinic/logo"/>
      </xsl:attribute>
      <xsl:attribute name="emtname">
        <xsl:value-of select="clinic/emtname"/>
      </xsl:attribute>
      <xsl:attribute name="emtaddress">
        <xsl:value-of select="clinic/emtaddress"/>
      </xsl:attribute>
      <xsl:attribute name="emtcity">
        <xsl:value-of select="clinic/emtcity"/>
      </xsl:attribute>
      <xsl:attribute name="emtstate">
        <xsl:value-of select="clinic/emtstate"/>
      </xsl:attribute>
      <xsl:attribute name="emtzip">
        <xsl:value-of select="clinic/emtzip"/>
      </xsl:attribute>
      <xsl:attribute name="emtphone">
        <xsl:value-of select="clinic/emtphone"/>
      </xsl:attribute>

      <!-- Client information -->
      <xsl:for-each select="client">
        <ClientInfo>
          <xsl:variable name="vClientId" select="id" />

          <xsl:attribute name="id">
            <xsl:value-of select="id"/>
          </xsl:attribute>
          <xsl:attribute name="firstname">
            <xsl:value-of select="firstname"/>
          </xsl:attribute>
          <xsl:attribute name="lastname">
            <xsl:value-of select="lastname"/>
          </xsl:attribute>
          <xsl:attribute name="title">
            <xsl:value-of select="title"/>
          </xsl:attribute>
          <xsl:attribute name="address1">
            <xsl:value-of select="address1"/>
          </xsl:attribute>
          <xsl:attribute name="address2">
            <xsl:value-of select="address2"/>
          </xsl:attribute>
          <xsl:attribute name="city">
            <xsl:value-of select="city"/>
          </xsl:attribute>
          <xsl:attribute name="state">
            <xsl:value-of select="state"/>
          </xsl:attribute>
          <xsl:attribute name="zip">
            <xsl:value-of select="zip"/>
          </xsl:attribute>
          <xsl:attribute name="country">
            <xsl:value-of select="country"/>
          </xsl:attribute>
          <xsl:attribute name="status">
            <xsl:value-of select="status"/>
          </xsl:attribute>

          <!-- Pet information -->
          <xsl:for-each select="pet">
            <Pet>
              <xsl:variable name="vPatientId" select="id" />
              <xsl:variable name="vInvoice" select="invno" />

              <xsl:attribute name="id">
                <xsl:value-of select="id"/>
              </xsl:attribute>
              <xsl:attribute name="name">
                <xsl:value-of select="name"/>
              </xsl:attribute>
              <xsl:attribute name="species">
                <xsl:value-of select="species"/>
              </xsl:attribute>
              <xsl:attribute name="breed">
                <xsl:value-of select="breed"/>
              </xsl:attribute>
              <xsl:attribute name="color">
                <xsl:value-of select="color"/>
              </xsl:attribute>
              <xsl:attribute name="weight">
                <xsl:value-of select="weight"/>
              </xsl:attribute>
              <xsl:attribute name="sex">
                <xsl:value-of select="sex"/>
              </xsl:attribute>
              <xsl:attribute name="rabiestag">
                <xsl:value-of select="rabiestag"/>
              </xsl:attribute>
              <xsl:attribute name="microchipid">
                <xsl:value-of select="microchipid"/>
              </xsl:attribute>
              <xsl:attribute name="birthdate">
                <xsl:value-of select="birthdate"/>
              </xsl:attribute>
              <xsl:attribute name="invno">
                <xsl:value-of select="invno"/>
              </xsl:attribute>
              <xsl:attribute name="quantity">
                <xsl:value-of select="quantity"/>
              </xsl:attribute>
              <xsl:attribute name="preview">
                <xsl:value-of select="preview"/>
              </xsl:attribute>
              <xsl:attribute name="photo">
                <xsl:value-of select="photo"/>
              </xsl:attribute>
              <xsl:attribute name="allergy">
                <xsl:value-of select="allergy"/>
              </xsl:attribute>

              <!-- Reminders information -->
              <xsl:for-each select="reminders/reminder">
                <Reminder>
                  <xsl:attribute name="prid">
                    <xsl:value-of select="$vPracticeId" />
                  </xsl:attribute>
                  <xsl:attribute name="clientid">
                    <xsl:value-of select="$vClientId" />
                  </xsl:attribute>
                  <xsl:attribute name="patientid">
                    <xsl:value-of select="$vPatientId" />
                  </xsl:attribute>
                  <xsl:attribute name="invoice">
                    <xsl:value-of select="$vInvoice" />
                  </xsl:attribute>

                  <xsl:attribute name="id">
                    <xsl:value-of select="id" />
                  </xsl:attribute>
                  <xsl:attribute name="name">
                    <xsl:value-of select="name" />
                  </xsl:attribute>
                  <xsl:attribute name="cname">
                    <xsl:value-of select="commonname" />
                  </xsl:attribute>
                  <xsl:attribute name="gdate">
                    <xsl:value-of select="dategiven" />
                  </xsl:attribute>
                  <xsl:attribute name="ddate">
                    <xsl:value-of select="duedate" />
                  </xsl:attribute>
                  <xsl:attribute name="priority">
                    <xsl:value-of select="priority" />
                  </xsl:attribute>
                </Reminder>
              </xsl:for-each>
            </Pet>
          </xsl:for-each>
        </ClientInfo>
      </xsl:for-each >
    </PracticeInfo>

    <!-- Total Counts -->
    <xsl:if test="position()= last()">
      <totalcount>
        <xsl:attribute name="card">
          <xsl:value-of select="../../cardcount" />
        </xsl:attribute>
        <xsl:attribute name="cardqty">
          <xsl:value-of select="../../cardquantity" />
        </xsl:attribute>
        <xsl:attribute name="client">
          <xsl:value-of select="../../clientcount" />
        </xsl:attribute>
        <xsl:attribute name="patient">
          <xsl:value-of select="../../patientcount" />
        </xsl:attribute>
        <xsl:attribute name="reminder">
          <xsl:value-of select="../../remindercount" />
        </xsl:attribute>
        <xsl:attribute name="photo">
          <xsl:value-of select="../../photocount" />
        </xsl:attribute>
      </totalcount>
    </xsl:if>
  </xsl:template>

  <!-- 
  <xsl:template match="petid">
    <Total>
    <xsl:attribute name="cards">
      <xsl:value-of select="cardcount" />
    </xsl:attribute>
    </Total>
  </xsl:template>
  -->
</xsl:stylesheet>