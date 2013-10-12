<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method="text" />
	<xsl:template match="/">
		<xsl:for-each select="projects/project/domain">
			&lt;VirtualHost 127.0.0.1:80&gt;
				ServerName <xsl:value-of select="./@name" />
				ServerAdmin webmaster@<xsl:value-of select="./@name" />
				SetEnv APPLICATION_ENV "<xsl:if test='../option[@name="env"]'><xsl:value-of select='../option[@name="env"]' /></xsl:if><xsl:if test='not(../option[@name="env"])'>development</xsl:if>"
				DocumentRoot <xsl:value-of select="../@public-path" />
				ErrorLog "logs/<xsl:value-of select="./@name" />-error.log"
				CustomLog "logs/<xsl:value-of select="./@name" />-access.log" common

				&lt;IfModule mod_php5.c&gt;
					php_admin_flag engine on
					<!-- php_admin_flag safe_mode on -->
					<!-- php_admin_value open_basedir ".:<xsl:if test="../@public-path"><xsl:value-of select="../@public-path" /></xsl:if><xsl:if test="not(../@project-path)"><xsl:value-of select="../@public-path" /></xsl:if>:/tmp" -->
				&lt;/IfModule&gt;
			&lt;/VirtualHost&gt;
		</xsl:for-each>
	</xsl:template>
</xsl:stylesheet>
