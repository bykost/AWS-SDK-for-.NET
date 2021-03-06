<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-05-15/'"/>
  <xsl:template match="ec2:DeleteInternetGatewayResponse">
    <xsl:apply-templates select="ec2:return"/>
  </xsl:template>
  <xsl:template match="ec2:return">
    <xsl:element name="DeleteInternetGatewayResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="../ec2:requestId"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>
